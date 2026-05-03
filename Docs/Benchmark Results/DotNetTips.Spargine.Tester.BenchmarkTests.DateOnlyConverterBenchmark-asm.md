## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.DateOnlyConverterBenchmark.Read()
       push      rsi
       push      rbx
       sub       rsp,138
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+130],rax
       mov       rbx,rcx
       mov       rdx,[rbx+140]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M00_L01:
       xor       r9d,r9d
       mov       [rsp+40],r9
       mov       [rsp+48],r9
       mov       byte ptr [rsp+50],0
       mov       byte ptr [rsp+51],0
       mov       byte ptr [rsp+52],0
       mov       byte ptr [rsp+53],0
       mov       byte ptr [rsp+54],0
       mov       byte ptr [rsp+55],0
       mov       [rsp+58],r9
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       lea       rcx,[rsp+78]
       lea       r9,[rsp+40]
       mov       r8d,1
       call      qword ptr [7FF9646E72E8]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       cmp       byte ptr [rsp+0A3],0
       jne       short M00_L05
       lea       rcx,[rsp+78]
       call      qword ptr [7FF9646E73A8]; System.Text.Json.Utf8JsonReader.ReadSingleSegment()
M00_L02:
       test      eax,eax
       je        short M00_L06
M00_L03:
       mov       rsi,[rbx+138]
       call      qword ptr [7FF96476ED48]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       r9,rax
       mov       rcx,rsi
       lea       rdx,[rsp+78]
       mov       r8,2042A2CBF28
       cmp       [rcx],ecx
       call      qword ptr [7FF96454A260]; DotNetTips.Spargine.Tester.Data.Converters.DateOnlyConverter.Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)
       mov       [rsp+38],eax
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rsp+38]
       call      qword ptr [7FF96476FA50]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateOnly, System.Private.CoreLib]](System.DateOnly ByRef)
       nop
       add       rsp,138
       pop       rbx
       pop       rsi
       ret
M00_L04:
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M00_L01
M00_L05:
       lea       rcx,[rsp+78]
       call      qword ptr [7FF9647E7978]
       jmp       short M00_L02
M00_L06:
       cmp       byte ptr [rsp+9C],0
       je        short M00_L03
       cmp       byte ptr [rsp+0A0],0
       jne       short M00_L03
       cmp       byte ptr [rsp+0BE],0
       jne       short M00_L03
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+78]
       mov       edx,20
       xor       r8d,r8d
       call      qword ptr [7FF9647E7990]
       int       3
; Total bytes of code 392
```
```assembly
; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rcx+30],xmm0
       mov       [rcx+24],r8b
       mov       byte ptr [rcx+25],0
       mov       rax,[r9]
       mov       [rcx],rax
       mov       rax,[r9+8]
       mov       [rcx+8],rax
       movzx     eax,byte ptr [r9+10]
       mov       [rcx+26],al
       movzx     eax,byte ptr [r9+11]
       mov       [rcx+27],al
       movzx     eax,byte ptr [r9+12]
       mov       [rcx+2E],al
       movzx     eax,byte ptr [r9+13]
       mov       [rcx+2C],al
       movzx     eax,byte ptr [r9+14]
       mov       [rcx+28],al
       movzx     eax,byte ptr [r9+15]
       mov       [rcx+29],al
       mov       rax,[r9+18]
       mov       [rcx+40],rax
       cmp       dword ptr [rcx+40],0
       jne       short M01_L00
       mov       dword ptr [rcx+40],40
M01_L00:
       vmovdqu   xmm0,xmmword ptr [r9+20]
       vmovdqu   xmmword ptr [rcx+48],xmm0
       mov       rax,[r9+30]
       mov       [rcx+58],rax
       xor       eax,eax
       mov       [rcx+20],eax
       mov       [rcx+18],rax
       mov       [rcx+10],rax
       movzx     eax,byte ptr [rcx+24]
       mov       [rcx+2A],al
       mov       byte ptr [rcx+2B],0
       xor       eax,eax
       mov       [rcx+98],rax
       mov       [rcx+0A0],rax
       mov       [rcx+70],rax
       mov       [rcx+78],rax
       mov       [rcx+60],rax
       mov       [rcx+68],rax
       mov       [rcx+80],rax
       mov       [rcx+88],rax
       mov       [rcx+90],rax
       mov       byte ptr [rcx+2D],0
       mov       rax,1C395401D00
       mov       rax,[rax]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rcx+0A8],xmm0
       mov       rdx,[rax+18]
       mov       [rcx+0B8],rdx
       ret
; Total bytes of code 238
```
```assembly
; System.Text.Json.Utf8JsonReader.ReadSingleSegment()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       xor       esi,esi
       xor       ecx,ecx
       mov       [rbx+98],rcx
       mov       [rbx+0A0],rcx
       mov       byte ptr [rbx+2E],0
       mov       ecx,[rbx+20]
       movsxd    rax,ecx
       mov       edx,[rbx+38]
       cmp       rax,rdx
       jge       near ptr M02_L06
       lea       rax,[rbx+30]
       cmp       ecx,[rax+8]
       jae       near ptr M02_L29
       mov       rax,[rax]
       mov       ecx,ecx
       movzx     edx,byte ptr [rax+rcx]
       cmp       edx,20
       jle       near ptr M02_L11
M02_L00:
       movsxd    rcx,dword ptr [rbx+20]
       mov       [rbx+18],rcx
       cmp       byte ptr [rbx+28],0
       jne       near ptr M02_L15
       cmp       edx,7B
       je        near ptr M02_L23
       cmp       edx,5B
       je        near ptr M02_L25
       mov       rsi,[rbx+30]
       mov       edi,[rbx+38]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       jbe       short M02_L05
       cmp       edx,2D
       je        short M02_L05
       mov       rcx,rbx
       call      qword ptr [7FF9646E7450]; System.Text.Json.Utf8JsonReader.ConsumeValue(Byte)
       test      eax,eax
       je        near ptr M02_L27
M02_L01:
       movzx     ecx,byte ptr [rbx+28]
       cmp       ecx,1
       je        near ptr M02_L28
       cmp       ecx,3
       je        near ptr M02_L28
       xor       ecx,ecx
M02_L02:
       mov       [rbx+27],cl
M02_L03:
       mov       esi,1
M02_L04:
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       mov       edx,[rbx+20]
       cmp       edx,edi
       ja        near ptr M02_L26
       mov       r8d,edx
       add       r8,rsi
       sub       edi,edx
       mov       [rsp+28],r8
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       lea       r8,[rsp+38]
       mov       rcx,rbx
       call      qword ptr [7FF9646E7AB0]; System.Text.Json.Utf8JsonReader.TryGetNumber(System.ReadOnlySpan`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L27
       mov       byte ptr [rbx+28],8
       mov       ecx,[rsp+38]
       add       [rbx+20],ecx
       movsxd    rcx,dword ptr [rsp+38]
       add       [rbx+8],rcx
       jmp       short M02_L01
M02_L06:
       cmp       byte ptr [rbx+27],0
       je        short M02_L04
       mov       rcx,rbx
       call      qword ptr [7FF9647E79A8]
       test      eax,eax
       je        short M02_L04
       cmp       dword ptr [rbx+58],0
       jne       short M02_L08
       cmp       byte ptr [rbx+44],2
       je        short M02_L09
M02_L07:
       movzx     r9d,byte ptr [rbx+28]
       cmp       r9d,4
       je        near ptr M02_L04
       cmp       r9d,2
       je        near ptr M02_L04
       jmp       short M02_L10
M02_L08:
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9d
       lea       r9,[rsp+28]
       mov       rcx,rbx
       mov       edx,19
       xor       r8d,r8d
       call      qword ptr [7FF9647E7990]
       int       3
M02_L09:
       cmp       byte ptr [rbx+28],6
       jne       short M02_L07
       jmp       near ptr M02_L04
M02_L10:
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9d
       lea       r9,[rsp+28]
       mov       rcx,rbx
       mov       edx,16
       xor       r8d,r8d
       call      qword ptr [7FF9647E7990]
       int       3
M02_L11:
       mov       rcx,rbx
       call      qword ptr [7FF9646E7438]; System.Text.Json.Utf8JsonReader.SkipWhiteSpace()
       movsxd    rcx,dword ptr [rbx+20]
       mov       edx,[rbx+38]
       cmp       rcx,rdx
       jl        near ptr M02_L14
       cmp       byte ptr [rbx+27],0
       je        near ptr M02_L04
       mov       rcx,rbx
       call      qword ptr [7FF9647E79A8]
       test      eax,eax
       je        near ptr M02_L04
       cmp       dword ptr [rbx+58],0
       je        short M02_L12
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9d
       lea       r9,[rsp+28]
       mov       rcx,rbx
       mov       edx,19
       xor       r8d,r8d
       call      qword ptr [7FF9647E7990]
       int       3
M02_L12:
       cmp       byte ptr [rbx+44],2
       jne       short M02_L13
       cmp       byte ptr [rbx+28],6
       je        near ptr M02_L04
M02_L13:
       movzx     r9d,byte ptr [rbx+28]
       cmp       r9d,4
       je        near ptr M02_L04
       cmp       r9d,2
       je        near ptr M02_L04
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9d
       lea       r9,[rsp+28]
       mov       rcx,rbx
       mov       edx,16
       xor       r8d,r8d
       call      qword ptr [7FF9647E7990]
       int       3
M02_L14:
       mov       ecx,[rbx+20]
       lea       rdx,[rbx+30]
       cmp       ecx,[rdx+8]
       jae       near ptr M02_L29
       mov       rdx,[rdx]
       movzx     edx,byte ptr [rdx+rcx]
       jmp       near ptr M02_L00
M02_L15:
       cmp       edx,2F
       je        near ptr M02_L21
       cmp       byte ptr [rbx+28],1
       jne       short M02_L18
       cmp       edx,7D
       jne       short M02_L16
       mov       rcx,rbx
       call      qword ptr [7FF9646EC228]; System.Text.Json.Utf8JsonReader.EndObject()
       jmp       near ptr M02_L22
M02_L16:
       cmp       edx,22
       je        short M02_L17
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9d
       lea       r9,[rsp+28]
       mov       rcx,rbx
       mov       r8d,edx
       mov       edx,0C
       call      qword ptr [7FF9647E7990]
       int       3
M02_L17:
       mov       edi,[rbx+20]
       mov       rbp,[rbx+8]
       mov       r14,[rbx]
       mov       rcx,rbx
       call      qword ptr [7FF9646E74F8]; System.Text.Json.Utf8JsonReader.ConsumePropertyName()
       mov       esi,eax
       test      esi,esi
       jne       near ptr M02_L04
       mov       [rbx+20],edi
       mov       byte ptr [rbx+28],1
       mov       [rbx+8],rbp
       mov       [rbx],r14
       jmp       near ptr M02_L04
M02_L18:
       cmp       byte ptr [rbx+28],3
       jne       short M02_L19
       cmp       edx,5D
       jne       short M02_L20
       mov       rcx,rbx
       call      qword ptr [7FF9646EC528]; System.Text.Json.Utf8JsonReader.EndArray()
       jmp       short M02_L22
M02_L19:
       cmp       byte ptr [rbx+28],5
       jne       short M02_L21
M02_L20:
       mov       rcx,rbx
       call      qword ptr [7FF9646E7450]; System.Text.Json.Utf8JsonReader.ConsumeValue(Byte)
       mov       esi,eax
       jmp       near ptr M02_L04
M02_L21:
       mov       rcx,rbx
       call      qword ptr [7FF9646E7BE8]; System.Text.Json.Utf8JsonReader.ConsumeNextTokenOrRollback(Byte)
       mov       esi,eax
       jmp       near ptr M02_L04
M02_L22:
       mov       esi,1
       jmp       near ptr M02_L04
M02_L23:
       lea       rcx,[rbx+48]
       call      qword ptr [7FF9647EE778]
       mov       byte ptr [rbx+28],1
       lea       rax,[rbx+30]
       mov       ecx,[rbx+20]
       lea       rdx,[rcx+1]
       mov       r8d,[rax+8]
       cmp       rdx,r8
       ja        short M02_L26
       add       rcx,[rax]
       mov       [rbx+98],rcx
       mov       dword ptr [rbx+0A0],1
       inc       dword ptr [rbx+20]
       inc       qword ptr [rbx+8]
       mov       byte ptr [rbx+26],1
M02_L24:
       mov       byte ptr [rbx+27],1
       jmp       near ptr M02_L03
M02_L25:
       lea       rcx,[rbx+48]
       inc       dword ptr [rcx+10]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       byte ptr [rbx+28],3
       lea       rcx,[rbx+30]
       mov       eax,[rbx+20]
       mov       edx,eax
       inc       rdx
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       ja        short M02_L26
       add       rax,[rcx]
       mov       [rbx+98],rax
       mov       dword ptr [rbx+0A0],1
       inc       dword ptr [rbx+20]
       inc       qword ptr [rbx+8]
       jmp       short M02_L24
M02_L26:
       call      qword ptr [7FF96431F6C0]
       int       3
M02_L27:
       xor       esi,esi
       jmp       near ptr M02_L04
M02_L28:
       mov       ecx,1
       jmp       near ptr M02_L02
M02_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 990
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,1C3954021A0
       mov       rax,[rax]
       test      rax,rax
       je        short M03_L00
       ret
M03_L00:
       mov       rcx,1C3954021A0
       xor       edx,edx
       jmp       qword ptr [7FF96476ED60]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Tester.Data.Converters.DateOnlyConverter.Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)
; 		var value = reader.GetString() ?? throw new JsonException(Resources.ErrorDateTextIsNullOrEmpty);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return DateOnly.Parse(value, IsoDateTimeOffsetConverter.Singleton.Culture);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return default;
; 		^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (FormatException e)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowJsonException(Resources.ErrorInvalidDateFormat, e);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp-20],rax
       mov       rbx,rdx
       movzx     ecx,byte ptr [rbx+28]
       cmp       ecx,0B
       je        near ptr M04_L20
       cmp       ecx,7
       jne       near ptr M04_L21
M04_L00:
       cmp       byte ptr [rbx+2D],0
       jne       near ptr M04_L22
       mov       rsi,[rbx+98]
       mov       edi,[rbx+0A0]
M04_L01:
       cmp       byte ptr [rbx+2E],0
       jne       near ptr M04_L25
       mov       [rbp-98],rsi
       mov       [rbp-90],edi
       lea       rcx,[rbp-98]
       call      qword ptr [7FF9646E7C60]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
M04_L02:
       test      rbx,rbx
       je        near ptr M04_L26
       mov       rcx,1C3954013E0
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       jne       short M04_L04
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M04_L12
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M04_L12
M04_L03:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M04_L04
       mov       rcx,1C395400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M04_L04
       mov       rcx,1C395400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L04:
       lea       rsi,[rbx+0C]
       mov       ebx,[rbx+8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-88],ymm0
       vmovdqu   ymmword ptr [rbp-68],ymm0
       vmovdqu   ymmword ptr [rbp-50],ymm0
       mov       [rbp-40],rsi
       mov       [rbp-38],ebx
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       dword ptr [rbp-74],0FFFFFFFF
       mov       dword ptr [rbp-70],0FFFFFFFF
       mov       rax,0BFF0000000000000
       mov       [rbp-80],rax
       mov       dword ptr [rbp-60],0FFFFFFFF
       test      rcx,rcx
       jne       near ptr M04_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M04_L14
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M04_L14
M04_L05:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M04_L06
       mov       rcx,1C395400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M04_L06
       mov       rcx,1C395400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M04_L15
M04_L06:
       cmp       byte ptr [rcx+61],0
       jne       near ptr M04_L16
       mov       rdx,[rcx+20]
       test      rdx,rdx
       je        near ptr M04_L16
M04_L07:
       mov       [rbp-0A8],rsi
       mov       [rbp-0A0],ebx
       lea       rcx,[rbp-0A8]
       lea       r9,[rbp-88]
       xor       r8d,r8d
       call      qword ptr [7FF96476EE68]; System.DateTimeParse.TryParse(System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.Globalization.DateTimeStyles, System.DateTimeResult ByRef)
       test      eax,eax
       jne       short M04_L10
       xor       eax,eax
       mov       ecx,11
M04_L08:
       test      ecx,ecx
       je        near ptr M04_L19
       jmp       near ptr M04_L18
M04_L09:
       call      qword ptr [7FF96476EE50]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       mov       rdx,rax
       jmp       short M04_L07
M04_L10:
       test      dword ptr [rbp-5C],4B78
       jne       short M04_L11
       mov       rdx,[rbp-48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,28B8FFC778816079
       mulx      rax,rax,rax
       shr       rax,25
       xor       ecx,ecx
       jmp       short M04_L08
M04_L11:
       xor       eax,eax
       mov       ecx,13
       jmp       short M04_L08
M04_L12:
       mov       ecx,2
       call      qword ptr [7FF9647ECF60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L03
M04_L13:
       call      qword ptr [7FF96414D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L14:
       mov       ecx,2
       call      qword ptr [7FF9647ECF60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L15:
       call      qword ptr [7FF96414D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M04_L06
M04_L16:
       mov       rdx,2042A2D0038
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       rdx,rax
       test      rdx,rdx
       je        short M04_L17
       mov       rcx,offset MT_System.Globalization.DateTimeFormatInfo
       cmp       [rdx],rcx
       je        short M04_L17
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L17:
       jmp       near ptr M04_L07
M04_L18:
       mov       [rbp-0A8],rsi
       mov       [rbp-0A0],ebx
       lea       rdx,[rbp-0A8]
       call      qword ptr [7FF9647ED890]
       int       3
M04_L19:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L20:
       xor       ebx,ebx
       jmp       near ptr M04_L02
M04_L21:
       cmp       ecx,5
       je        near ptr M04_L00
       call      qword ptr [7FF9647E7C60]
       int       3
M04_L22:
       vmovdqu   xmm0,xmmword ptr [rbx+0A8]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       mov       rcx,[rbx+0B8]
       mov       [rbp-20],rcx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9647E7C30]
       test      rax,rax
       jne       short M04_L23
       xor       esi,esi
       xor       edi,edi
       jmp       short M04_L24
M04_L23:
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M04_L24:
       jmp       near ptr M04_L01
M04_L25:
       mov       [rbp-98],rsi
       mov       [rbp-90],edi
       lea       rcx,[rbp-98]
       call      qword ptr [7FF9646E7D38]; System.Text.Json.JsonReaderHelper.GetUnescapedString(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
       jmp       near ptr M04_L02
M04_L26:
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF96476EDA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF96476EDC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF96476EE08]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M04_L27
       call      qword ptr [7FF9647EE8F8]
       mov       rsi,rax
M04_L27:
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FF9647EE910]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 992
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateOnly, System.Private.CoreLib]](System.DateOnly ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.DateOnlyConverterBenchmark.Write()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+148]
       xor       ecx,ecx
       mov       [rsi+10],ecx
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        near ptr M00_L44
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+70],rcx
       mov       [rdi+78],rcx
       mov       byte ptr [rdi+3C],20
       mov       dword ptr [rdi+2C],2
       mov       dword ptr [rdi+30],2
       mov       dword ptr [rdi+78],3E8
       mov       [rbp-40],rdi
       mov       rsi,[rbx+138]
       mov       ebx,[rbx+150]
       mov       rcx,2040B001D48
       cmp       qword ptr [rcx],0
       je        near ptr M00_L19
M00_L00:
       mov       [rbp-20],ebx
       mov       rbx,[rsi+30]
       mov       rcx,2040B0013E0
       mov       rcx,[rcx]
       mov       rsi,[rcx+38]
       test      rsi,rsi
       jne       short M00_L02
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L01:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L02
       mov       rax,2040B000190
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L02
       mov       rax,2040B000170
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L21
M00_L02:
       mov       r8,rsi
       test      rbx,rbx
       je        short M00_L03
       cmp       dword ptr [rbx+8],0
       jne       short M00_L04
M00_L03:
       mov       rbx,2449FF71A20
M00_L04:
       mov       ecx,[rbx+8]
       cmp       ecx,1
       je        near ptr M00_L22
       lea       rax,[rbx+0C]
       xor       edx,edx
       cmp       edx,ecx
       jl        near ptr M00_L10
M00_L05:
       mov       ecx,[rbp-20]
       mov       rdx,0C92A69C000
       imul      rcx,rdx
       mov       rdx,rbx
       mov       r9,8000000000000000
       call      qword ptr [7FF96478E4D8]; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
M00_L06:
       test      rax,rax
       je        near ptr M00_L40
       lea       rbx,[rax+0C]
       mov       esi,[rax+8]
       cmp       esi,9EF21AA
       jg        near ptr M00_L41
       lea       rcx,[rdi+70]
       mov       rcx,[rcx]
       test      esi,esi
       jne       near ptr M00_L12
       mov       eax,0FFFFFFFF
       jmp       near ptr M00_L13
M00_L07:
       cmp       r10d,5C
       je        near ptr M00_L33
       cmp       r10d,66
       je        near ptr M00_L39
       cmp       r10d,68
       je        near ptr M00_L39
M00_L08:
       inc       edx
M00_L09:
       cmp       edx,ecx
       jge       short M00_L05
M00_L10:
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       cmp       r10d,4B
       jle       short M00_L11
       cmp       r10d,68
       jle       short M00_L07
       cmp       r10d,73
       jle       near ptr M00_L32
       cmp       r10d,74
       je        near ptr M00_L39
       cmp       r10d,7A
       je        near ptr M00_L39
       jmp       short M00_L08
M00_L11:
       cmp       r10d,3A
       jg        near ptr M00_L31
       cmp       r10d,22
       je        near ptr M00_L34
       cmp       r10d,27
       je        near ptr M00_L34
       cmp       r10d,3A
       je        near ptr M00_L39
       jmp       short M00_L08
M00_L12:
       mov       [rbp-28],rbx
       mov       rdx,rbx
       mov       r8,2040B001468
       test      rcx,rcx
       cmove     rcx,[r8]
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M00_L13:
       xor       ecx,ecx
       mov       [rbp-28],rcx
       cmp       eax,0FFFFFFFF
       jne       short M00_L16
       test      byte ptr [rdi+7C],2
       jne       short M00_L14
       movzx     ecx,byte ptr [rdi+38]
       cmp       ecx,10
       sete      al
       movzx     eax,al
       movzx     edx,byte ptr [rdi+3A]
       cmp       ecx,edx
       sete      cl
       movzx     ecx,cl
       or        ecx,eax
       jne       short M00_L14
       mov       rcx,rdi
       call      qword ptr [7FF9648169A0]
M00_L14:
       test      byte ptr [rdi+7C],1
       jne       short M00_L15
       mov       [rbp-38],rbx
       mov       [rbp-30],esi
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FF96478E748]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M00_L17
M00_L15:
       mov       [rbp-38],rbx
       mov       [rbp-30],esi
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FF9648169B8]
       jmp       short M00_L17
M00_L16:
       mov       [rbp-38],rbx
       mov       [rbp-30],esi
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       mov       r8d,eax
       call      qword ptr [7FF964816988]
M00_L17:
       or        dword ptr [rdi+28],80000000
       mov       byte ptr [rdi+3A],7
M00_L18:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF96478E3E8]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L43
M00_L19:
       mov       rcx,2040B001D48
       xor       edx,edx
       call      qword ptr [7FF96478E430]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       jmp       near ptr M00_L00
M00_L20:
       mov       ecx,2
       call      qword ptr [7FF9648151D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L21:
       call      qword ptr [7FF96416D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L22:
       movzx     ecx,word ptr [rbx+0C]
       or        ecx,20
       cmp       ecx,6D
       jg        short M00_L23
       cmp       ecx,64
       je        near ptr M00_L29
       cmp       ecx,6D
       je        near ptr M00_L29
       jmp       short M00_L24
M00_L23:
       cmp       ecx,6F
       je        short M00_L25
       cmp       ecx,72
       je        near ptr M00_L27
       cmp       ecx,79
       je        near ptr M00_L29
M00_L24:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9648160D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9648160E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       ebx,[rbp-20]
       mov       rcx,offset MT_System.DateOnly+<>c
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2040B0021D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L26
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.DateOnly>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.DateOnly+<>c
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2040B0021C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FF9648120A0
       call      qword ptr [7FF964166BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_System.DateOnly+<>c
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2040B0021D0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
M00_L26:
       mov       edx,ebx
       mov       ecx,0A
       call      qword ptr [7FF964816088]
       jmp       near ptr M00_L30
M00_L27:
       mov       ebx,[rbp-20]
       mov       rcx,offset MT_System.DateOnly+<>c
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2040B0021D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L28
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.DateOnly>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.DateOnly+<>c
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2040B0021C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FF9648120B8
       call      qword ptr [7FF964166BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_System.DateOnly+<>c
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2040B0021D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
M00_L28:
       mov       edx,ebx
       mov       ecx,10
       call      qword ptr [7FF964816088]
       jmp       short M00_L30
M00_L29:
       lea       rcx,[rbp-20]
       call      qword ptr [7FF964817AC8]
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF964817AE0]
M00_L30:
       jmp       near ptr M00_L06
M00_L31:
       cmp       r10d,46
       je        near ptr M00_L39
       cmp       r10d,48
       je        near ptr M00_L39
       cmp       r10d,4B
       je        near ptr M00_L39
       jmp       near ptr M00_L08
M00_L32:
       cmp       r10d,6D
       je        near ptr M00_L39
       cmp       r10d,73
       je        near ptr M00_L39
       jmp       near ptr M00_L08
M00_L33:
       lea       r10d,[rcx-1]
       cmp       edx,r10d
       je        short M00_L37
       add       edx,2
       jmp       near ptr M00_L09
M00_L34:
       mov       r10d,edx
       lea       edx,[r10+1]
       movzx     esi,word ptr [rax+r10*2]
       jmp       short M00_L36
M00_L35:
       inc       edx
M00_L36:
       cmp       edx,ecx
       jge       short M00_L38
       cmp       edx,ecx
       jae       near ptr M00_L42
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       cmp       r10d,esi
       jne       short M00_L35
       jmp       near ptr M00_L08
M00_L37:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9648160D0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9648160E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF964816100]
       mov       rdi,rax
       mov       [rbx+8],si
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF964816118]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9648160E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9648160D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9648160E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       rcx,rdi
       call      qword ptr [7FF964816958]
       jmp       near ptr M00_L18
M00_L41:
       mov       ecx,esi
       call      qword ptr [7FF964816970]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      M00_L45
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L44:
       mov       ecx,3BFA
       mov       rdx,7FF96453A3E8
       call      qword ptr [7FF96416F228]
       mov       rcx,rax
       call      qword ptr [7FF964814FD8]
       int       3
M00_L45:
       sub       rsp,28
       mov       rcx,[rbp-40]
       cmp       qword ptr [rcx+10],0
       jne       short M00_L46
       cmp       qword ptr [rcx+8],0
       je        short M00_L47
M00_L46:
       call      qword ptr [7FF96478E3E8]; System.Text.Json.Utf8JsonWriter.Flush()
       xor       ecx,ecx
       mov       rbx,[rbp-40]
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1706
```
```assembly
; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqa   xmmword ptr [rbp+70],xmm4
       xor       eax,eax
       mov       [rbp+80],rax
       mov       rax,6AD78EF44F44
       mov       [rbp+8],rax
       mov       [rbp+0B0],rcx
       mov       rbx,rdx
       mov       rcx,r8
       mov       rsi,r9
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L04
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L04
       cmp       dword ptr [rbx+8],1
       je        near ptr M01_L19
       test      rcx,rcx
       jne       near ptr M01_L31
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L32
M01_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L02
       mov       rcx,2040B000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L02
       mov       rcx,2040B000170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L33
M01_L02:
       cmp       byte ptr [rcx+61],0
       jne       near ptr M01_L34
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M01_L34
M01_L03:
       mov       [rbp+80],rax
       jmp       near ptr M01_L07
M01_L04:
       test      rcx,rcx
       jne       near ptr M01_L12
       call      qword ptr [7FF964785BD8]; System.Globalization.DateTimeFormatInfo.get_CurrentInfo()
M01_L05:
       mov       [rbp+80],rax
       mov       rcx,8000000000000000
       cmp       rsi,rcx
       jne       near ptr M01_L16
       mov       rcx,[rbp+0B0]
       mov       rdx,[rbp+80]
       call      qword ptr [7FF9648161C0]
       test      eax,eax
       jne       near ptr M01_L13
       mov       rbx,[rbp+80]
       test      byte ptr [7FF96479A548],1
       je        near ptr M01_L14
M01_L06:
       mov       rcx,2040B001E80
       cmp       rbx,[rcx]
       je        near ptr M01_L15
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FF9648161D8]
       mov       rbx,rax
M01_L07:
       test      [rsp],esp
       sub       rsp,200
       lea       rdx,[rsp+30]
       mov       [rbp+30],rdx
       mov       dword ptr [rbp+38],100
       mov       rdx,[rbp+30]
       mov       ecx,[rbp+38]
       xor       r8d,r8d
       mov       [rbp+60],r8
       mov       [rbp+68],r8d
       mov       [rbp+70],rdx
       mov       [rbp+78],ecx
       mov       rcx,[rbp+0B0]
       test      rbx,rbx
       jne       near ptr M01_L11
       xor       edx,edx
       xor       r8d,r8d
M01_L08:
       mov       [rbp+10],rdx
       mov       [rbp+18],r8d
       lea       rdx,[rbp+60]
       mov       [rsp+20],rdx
       lea       rdx,[rbp+10]
       mov       r8,[rbp+80]
       mov       r9,rsi
       call      qword ptr [7FF9647866E8]; System.DateTimeFormat.FormatCustomized[[System.Char, System.Private.CoreLib]](System.DateTime, System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.TimeSpan, System.Collections.Generic.ValueListBuilder`1<Char> ByRef)
       mov       ecx,[rbp+68]
       cmp       ecx,[rbp+78]
       ja        near ptr M01_L36
       mov       rax,[rbp+70]
       mov       [rbp+10],rax
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+60]
       test      rdx,rdx
       jne       near ptr M01_L37
M01_L09:
       mov       rax,rdi
       mov       r8,6AD78EF44F44
       cmp       [rbp+8],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L11:
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       jmp       near ptr M01_L08
M01_L12:
       call      qword ptr [7FF96478E4F0]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       near ptr M01_L05
M01_L13:
       mov       ecx,13
       call      qword ptr [7FF964166670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       mov       [rbp+20],rdx
       mov       [rbp+28],r8d
       lea       rdx,[rbp+20]
       lea       r8,[rbp+58]
       call      qword ptr [7FF964816148]
       jmp       short M01_L09
M01_L14:
       mov       rcx,offset MT_System.DateTimeFormat
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,13
       call      qword ptr [7FF964166670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+50]
       mov       rdx,8000000000000000
       call      qword ptr [7FF964816190]
       jmp       near ptr M01_L09
M01_L16:
       mov       rcx,[rbp+0B0]
       mov       rdx,[rbp+80]
       call      qword ptr [7FF9648161C0]
       test      eax,eax
       je        short M01_L17
       mov       rbx,2449FF7FFE0
       mov       rcx,offset MT_System.DateTimeFormat
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2040B001E80
       mov       rcx,[rcx]
       mov       [rbp+80],rcx
       jmp       near ptr M01_L07
M01_L17:
       mov       rbx,[rbp+80]
       mov       rcx,offset MT_System.DateTimeFormat
       call      qword ptr [7FF964165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2040B001E80
       cmp       rbx,[rcx]
       jne       short M01_L18
       mov       ecx,1A
       call      qword ptr [7FF964166670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+48]
       mov       rdx,rsi
       call      qword ptr [7FF964816190]
       jmp       near ptr M01_L09
M01_L18:
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FF9648161F0]
       mov       rbx,rax
       jmp       near ptr M01_L07
M01_L19:
       movzx     eax,word ptr [rbx+0C]
       cmp       eax,52
       jg        short M01_L20
       cmp       eax,4F
       je        short M01_L22
       cmp       eax,52
       je        near ptr M01_L23
       jmp       short M01_L21
M01_L20:
       cmp       eax,55
       je        near ptr M01_L25
       add       eax,0FFFFFF91
       cmp       eax,6
       ja        short M01_L21
       lea       rdx,[7FF9648752C0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M01_L00]
       add       rdx,r8
       jmp       rdx
M01_L21:
       test      rcx,rcx
       je        near ptr M01_L29
       jmp       near ptr M01_L28
M01_L22:
       test      [rsp],esp
       sub       rsp,50
       lea       rdi,[rsp+30]
       mov       rcx,[rbp+0B0]
       mov       [rbp+20],rdi
       mov       dword ptr [rbp+28],21
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FF964816178]
       mov       ecx,[rbp+40]
       cmp       ecx,21
       ja        near ptr M01_L36
       mov       [rbp+30],rdi
       mov       [rbp+38],ecx
       lea       rcx,[rbp+30]
       call      qword ptr [7FF9643FC9D8]; System.Span`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdi,rax
       jmp       near ptr M01_L09
M01_L23:
       mov       ecx,1D
       call      qword ptr [7FF964166670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FF964816160]
M01_L24:
       jmp       near ptr M01_L09
       mov       ecx,13
       call      qword ptr [7FF964166670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       mov       [rbp+20],rdx
       mov       [rbp+28],r8d
       lea       rdx,[rbp+20]
       lea       r8,[rbp+40]
       call      qword ptr [7FF964816148]
       jmp       short M01_L24
       mov       ecx,14
       call      qword ptr [7FF964166670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FF964816130]
       jmp       short M01_L24
M01_L25:
       test      rcx,rcx
       je        short M01_L26
       call      qword ptr [7FF96478E4F0]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       short M01_L27
M01_L26:
       call      qword ptr [7FF964785BD8]; System.Globalization.DateTimeFormatInfo.get_CurrentInfo()
M01_L27:
       mov       [rbp+80],rax
       lea       rcx,[rbp+0B0]
       lea       rdx,[rbp+80]
       mov       r8,rsi
       call      qword ptr [7FF964816208]
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FF964816220]
       mov       rbx,rax
       jmp       near ptr M01_L07
M01_L28:
       call      qword ptr [7FF96478E4F0]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       short M01_L30
M01_L29:
       call      qword ptr [7FF964785BD8]; System.Globalization.DateTimeFormatInfo.get_CurrentInfo()
M01_L30:
       mov       [rbp+80],rax
       movzx     ecx,word ptr [rbx+0C]
       mov       rdx,[rbp+80]
       call      qword ptr [7FF964816238]
       mov       rbx,rax
       jmp       near ptr M01_L07
M01_L31:
       call      qword ptr [7FF96478E4F0]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       near ptr M01_L03
M01_L32:
       mov       ecx,2
       call      qword ptr [7FF9648151D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L01
M01_L33:
       call      qword ptr [7FF96416D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       rdx,2449FF80038
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L35
       mov       rcx,offset MT_System.Globalization.DateTimeFormatInfo
       cmp       [rdx],rcx
       je        short M01_L35
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L35:
       mov       rax,rdx
       jmp       near ptr M01_L03
M01_L36:
       call      qword ptr [7FF96433F228]
       int       3
M01_L37:
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,2040B000B38
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF964423908]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L09
; Total bytes of code 1514
```
```assembly
; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,90
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       rbx,rcx
       mov       rbp,rdx
       mov       ecx,[rbp+8]
       lea       eax,[rcx+rcx*2]
       add       eax,3
       mov       ecx,[rbx+4C]
       mov       edx,ecx
       sub       edx,[rbx+34]
       cmp       edx,eax
       jge       near ptr M02_L06
       test      ecx,ecx
       jne       near ptr M02_L16
       mov       r14d,100
       cmp       eax,100
       cmovg     r14d,eax
       cmp       qword ptr [rbx+10],0
       jne       short M02_L01
       lea       rdi,[rbx+40]
       mov       rcx,[rbx+8]
       lea       rdx,[rsp+60]
       mov       r8d,r14d
       mov       r11,7FF9640B0A68
       call      qword ptr [r11]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       cmp       [rbx+4C],r14d
       jge       near ptr M02_L06
M02_L00:
       call      qword ptr [7FF964816B38]
       int       3
M02_L01:
       mov       rsi,[rbx+18]
       cmp       [rsi],sil
       test      r14d,r14d
       jl        near ptr M02_L14
       mov       ecx,1
       test      r14d,r14d
       cmove     r14d,ecx
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       sub       edx,[rsi+10]
       cmp       edx,r14d
       jge       short M02_L04
       mov       edx,[rcx+8]
       cmp       r14d,edx
       mov       eax,edx
       cmovge    eax,r14d
       mov       r8d,eax
       test      edx,edx
       jne       short M02_L02
       mov       r8d,100
       cmp       eax,100
       cmovl     eax,r8d
       mov       r8d,eax
M02_L02:
       add       r8d,edx
       jns       short M02_L03
       mov       r8d,[rcx+8]
       sub       r8d,[rsi+10]
       sub       edx,r8d
       lea       ecx,[rdx+r14]
       cmp       ecx,7FFFFFC7
       ja        short M02_L07
       mov       r8d,7FFFFFC7
M02_L03:
       lea       rcx,[rsi+8]
       mov       edx,r8d
       call      qword ptr [7FF96478C0C0]; System.Array.Resize[[System.Byte, System.Private.CoreLib]](Byte[] ByRef, Int32)
M02_L04:
       mov       rdx,[rsi+8]
       mov       esi,[rsi+10]
       test      rdx,rdx
       je        near ptr M02_L15
       mov       edi,[rdx+8]
       cmp       edi,esi
       jb        near ptr M02_L13
       sub       edi,esi
M02_L05:
       lea       rcx,[rbx+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+48],esi
       mov       [rbx+4C],edi
M02_L06:
       lea       rsi,[rbx+40]
       xor       edi,edi
       xor       r14d,r14d
       mov       rcx,[rsi]
       test      rcx,rcx
       je        short M02_L10
       mov       rax,[rcx]
       mov       rdx,rax
       test      dword ptr [rdx],80000000
       je        short M02_L08
       lea       rdi,[rcx+10]
       mov       r14d,[rcx+8]
       jmp       short M02_L09
M02_L07:
       call      qword ptr [7FF964816BE0]
       int       3
M02_L08:
       lea       rdx,[rsp+50]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,[rsp+58]
       mov       rdi,[rsp+50]
M02_L09:
       mov       r8d,[rsi+8]
       and       r8d,7FFFFFFF
       mov       edx,[rsi+0C]
       mov       ecx,edx
       add       rcx,r8
       mov       r9d,r14d
       cmp       rcx,r9
       ja        near ptr M02_L13
       add       rdi,r8
       mov       r14d,edx
M02_L10:
       cmp       dword ptr [rbx+28],0
       jl        near ptr M02_L19
M02_L11:
       mov       esi,[rbx+34]
       lea       r8d,[rsi+1]
       mov       [rbx+34],r8d
       cmp       esi,r14d
       jae       near ptr M02_L20
       mov       r8d,esi
       mov       byte ptr [rdi+r8],22
       mov       rcx,[rbp]
       mov       edx,[rbp+8]
       mov       r8d,[rbx+34]
       cmp       r8d,r14d
       ja        near ptr M02_L13
       mov       esi,r8d
       add       rsi,rdi
       mov       r9d,r14d
       sub       r9d,r8d
       mov       [rsp+48],rcx
       mov       r8,rcx
       mov       [rsp+40],rsi
       mov       [rsp+38],r8
       mov       [rsp+30],rsi
       test      edx,edx
       je        short M02_L12
       lea       r8,[rsp+38]
       mov       [rsp+20],r8
       lea       r8,[rsp+30]
       mov       [rsp+28],r8
       mov       r8,rsi
       call      qword ptr [7FF964167C00]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
M02_L12:
       mov       eax,[rsp+30]
       sub       eax,esi
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       add       eax,[rbx+34]
       mov       esi,eax
       mov       [rbx+34],esi
       lea       eax,[rsi+1]
       mov       [rbx+34],eax
       cmp       esi,r14d
       jae       near ptr M02_L20
       mov       eax,esi
       mov       byte ptr [rdi+rax],22
       add       rsp,90
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L13:
       call      qword ptr [7FF96433F228]
       int       3
M02_L14:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1C3
       mov       rdx,7FF96452B688
       call      qword ptr [7FF96416F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9644E4210]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       test      esi,esi
       jne       short M02_L13
       xor       edx,edx
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M02_L05
M02_L16:
       mov       r14d,1000
       cmp       eax,1000
       cmovg     r14d,eax
       cmp       qword ptr [rbx+10],0
       je        short M02_L18
       mov       r8d,r14d
       add       r8d,[rbx+34]
       cmp       r8d,7FEFFFFF
       jbe       short M02_L17
       mov       ecx,r8d
       call      qword ptr [7FF964816B50]
       int       3
M02_L17:
       lea       rdi,[rbx+40]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+70]
       cmp       [rcx],ecx
       call      qword ptr [7FF96453CB48]; System.Buffers.ArrayBufferWriter`1[[System.Byte, System.Private.CoreLib]].GetMemory(Int32)
       lea       rsi,[rsp+70]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       jmp       near ptr M02_L06
M02_L18:
       mov       rcx,[rbx+8]
       mov       edx,[rbx+34]
       mov       r11,7FF9640B0A58
       call      qword ptr [r11]
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
       lea       rdi,[rbx+40]
       mov       rcx,[rbx+8]
       lea       rdx,[rsp+80]
       mov       r8d,r14d
       mov       r11,7FF9640B0A60
       call      qword ptr [r11]
       lea       rsi,[rsp+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       cmp       [rbx+4C],r14d
       jge       near ptr M02_L06
       jmp       near ptr M02_L00
M02_L19:
       mov       esi,[rbx+34]
       lea       r8d,[rsi+1]
       mov       [rbx+34],r8d
       cmp       esi,r14d
       jae       short M02_L20
       mov       r8d,esi
       mov       byte ptr [rdi+r8],2C
       jmp       near ptr M02_L11
M02_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 920
```
```assembly
; System.Text.Json.Utf8JsonWriter.Flush()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M03_L00
       cmp       qword ptr [rbx+8],0
       je        short M03_L03
M03_L00:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       test      rsi,rsi
       jne       short M03_L04
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M03_L02
       mov       rcx,[rbx+8]
       mov       rax,offset MT_System.Buffers.ArrayBufferWriter<System.Byte>
       cmp       [rcx],rax
       jne       near ptr M03_L08
       test      edx,edx
       jl        near ptr M03_L06
       mov       eax,[rcx+10]
       mov       r8,[rcx+8]
       mov       r8d,[r8+8]
       sub       r8d,edx
       cmp       eax,r8d
       jg        near ptr M03_L07
       add       eax,edx
       mov       [rcx+10],eax
M03_L01:
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
M03_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M03_L03:
       call      qword ptr [7FF964816028]
       int       3
M03_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M03_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF96453CB40]; System.Buffers.ArrayBufferWriter`1[[System.Byte, System.Private.CoreLib]].Advance(Int32)
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF964816040]
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       rcx,[rbx+18]
       movsxd    rcx,dword ptr [rcx+10]
       add       [rbx+20],rcx
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF964816058]
M03_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M03_L02
M03_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1B7
       mov       rdx,7FF96452B688
       call      qword ptr [7FF96416F228]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9644E6100]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L07:
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       call      qword ptr [7FF964816C10]
       int       3
M03_L08:
       mov       r11,7FF9640B0A40
       call      qword ptr [r11]
       jmp       near ptr M03_L01
; Total bytes of code 337
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       call      qword ptr [7FF9D5D59CB8]
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9D5D5E4B0]; Precode of System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       call      qword ptr [7FF9D5D584E0]
       cmp       byte ptr [rax],0
       je        short M04_L01
       call      qword ptr [7FF9D5D5EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rdx,rax
M04_L00:
       mov       rcx,rdi
       call      qword ptr [7FF9D5D5E4B8]
       mov       byte ptr [rdi+9E],1
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateDelegate[[System.__Canon, System.Private.CoreLib]](System.Reflection.Emit.DynamicMethod)]
       mov       rdx,rbx
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF9D5D5C540]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       call      qword ptr [7FF9D5D585A0]
       mov       rdx,[rax]
       jmp       short M04_L00
; Total bytes of code 116
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF9C398CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
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
       call      qword ptr [7FF9C39747E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF9C398B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF9C398CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FF9C398A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FF964165C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M08_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      qword ptr [7FF9648153B0]
       int       3
; Total bytes of code 44
```

