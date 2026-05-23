# Copilot Prompts for the `dotnet-pinvoke` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/dotnet-pinvoke/skill.md`

This skill covers correctly calling native (C/C++) libraries from .NET using both `[DllImport]` and `[LibraryImport]` — including function signatures, type mapping, string marshalling, memory ownership, `SafeHandle`, callbacks, cross-platform library loading, and migrating legacy `DllImport` declarations to `LibraryImport` for AOT and trimming compatibility.

---

## Writing a New Declaration

```text
Use the dotnet-pinvoke skill to write a [LibraryImport] declaration for the following C function signature: [paste C header here]. My app targets .NET 10. Include the correct type mappings, string marshalling, calling convention (if needed), and EntryPoint if the managed name differs from the native export.
```

```text
Use the dotnet-pinvoke skill to write a [DllImport] declaration for the following C function: [paste C header here]. I am targeting .NET Framework 4.8. Map every parameter type correctly, specify the string encoding explicitly, and flag any types that require special attention (long, size_t, BOOL, bool).
```

```text
Use the dotnet-pinvoke skill to wrap this entire C header file for use from .NET 10: [paste header]. Use LibraryImport for all declarations, map all types correctly, use SafeHandle for any handle types, and group the declarations into a static partial class.
```

---

## Type Mapping

```text
Use the dotnet-pinvoke skill to review the type mappings in this P/Invoke declaration. Check for incorrect use of int or long for C long, ulong for size_t, bool without MarshalAs, and raw IntPtr where SafeHandle should be used.
```

```text
Use the dotnet-pinvoke skill to verify the struct layout for this P/Invoke struct. Check field order, packing, alignment, and confirm that Marshal.SizeOf<T>() will match the native sizeof.
```

---

## String Marshalling

```text
Use the dotnet-pinvoke skill to review string marshalling in this P/Invoke code. Check that encoding is specified explicitly (no CharSet.Auto), that Windows API calls use the W (UTF-16) variant, and that cross-platform C library calls use UTF-8. Flag any StringBuilder output buffer patterns that should be replaced.
```

```text
Use the dotnet-pinvoke skill to fix the string marshalling in this [DllImport] declaration. The native function expects UTF-8 encoded strings on Linux and UTF-16 on Windows. Show me the correct DllImport and LibraryImport versions for both.
```

---

## Memory Ownership and Lifetime

```text
Use the dotnet-pinvoke skill to review memory ownership in this P/Invoke code. Identify who allocates and who frees each buffer or handle, verify that the correct allocator is paired with the correct free function, and flag any places where Marshal.FreeHGlobal or Marshal.FreeCoTaskMem may be called on malloc'd memory.
```

```text
Use the dotnet-pinvoke skill to implement the caller-allocates pattern for a native function that writes a UTF-8 string into a buffer I provide. The native signature is: [paste C header]. Use Span<byte> and stackalloc where appropriate.
```

```text
Use the dotnet-pinvoke skill to implement the callee-allocates pattern for this native function that returns a heap-allocated string I must free: [paste C header]. Wrap the allocation and free correctly so the string cannot leak on exception.
```

```text
Use the dotnet-pinvoke skill to review pinning usage in this code. Verify that fixed is used for synchronous cases and GCHandle.Pinned is used only when native code stores the pointer or runs asynchronously. Flag any cases where managed objects may move while native code holds a pointer.
```

---

## SafeHandle

```text
Use the dotnet-pinvoke skill to wrap the native handle type returned by this function in a SafeHandle: [paste C header for create and destroy functions]. Implement SafeHandleZeroOrMinusOneIsInvalid, wire up the destroy function in ReleaseHandle, and show correct usage with using.
```

```text
Use the dotnet-pinvoke skill to review this P/Invoke code for raw IntPtr usage that should be replaced with SafeHandle. For each instance, generate the SafeHandle subclass and update the affected declarations.
```

---

## Error Handling

```text
Use the dotnet-pinvoke skill to add correct error handling to this P/Invoke declaration. The function uses Win32 SetLastError — add SetLastPInvokeError = true to the LibraryImport and show how to throw a Win32Exception with the correct error code on failure.
```

```text
Use the dotnet-pinvoke skill to add HRESULT error handling to this native call. The function returns an HRESULT — show the correct way to check it and throw the appropriate managed exception using Marshal.ThrowExceptionForHR.
```

---

## Callbacks

```text
Use the dotnet-pinvoke skill to implement a native callback for this C function pointer signature: [paste C typedef]. My app targets .NET 8+. Use UnmanagedCallersOnly where possible. If instance state is needed, show the delegate-with-rooting fallback and explain how to prevent the delegate from being garbage collected.
```

```text
Use the dotnet-pinvoke skill to review callback usage in this P/Invoke code. Check that delegates passed as function pointers are rooted to prevent GC collection, that GC.KeepAlive is used where Marshal.GetFunctionPointerForDelegate is called, and that [UnmanagedFunctionPointer] includes CallingConvention only if targeting Windows x86.
```

---

## Cross-Platform Library Loading

```text
Use the dotnet-pinvoke skill to make this P/Invoke declaration cross-platform. The native library is named mylib.dll on Windows, libmylib.so on Linux, and libmylib.dylib on macOS. Use NativeLibrary.SetDllImportResolver for runtime-based resolution.
```

```text
Use the dotnet-pinvoke skill to review this cross-platform P/Invoke code for CLong and CULong usage. Verify that C long and unsigned long are mapped to CLong/CULong and not to int, long, or ulong, and check whether [assembly: DisableRuntimeMarshalling] is required.
```

---

## Migrating DllImport to LibraryImport

```text
Use the dotnet-pinvoke skill to migrate all [DllImport] declarations in this file to [LibraryImport]. My project targets .NET 10. Replace CharSet with StringMarshalling, SetLastError with SetLastPInvokeError, add partial to the containing class, remove unnecessary CallingConvention attributes, and fix any SYSLIB1054–SYSLIB1057 analyzer warnings.
```

```text
Use the dotnet-pinvoke skill to check whether this DllImport declaration can be safely migrated to LibraryImport. Identify any types or patterns that are not source-generator compatible and suggest what needs to change before migrating.
```

---

## Reviewing Existing P/Invoke Code

```text
Use the dotnet-pinvoke skill to review the P/Invoke declarations in this file using the validation checklist. Check signature correctness, calling convention, string encoding, memory ownership documentation, SafeHandle usage, delegate rooting, SetLastError, struct layout, CLong/CULong, and bool MarshalAs. Report every violation with its location and a concrete fix.
```

```text
Use the dotnet-pinvoke skill to diagnose why this P/Invoke call is causing an AccessViolationException. Review the signature against the native header, check type sizes, calling convention, and memory ownership to find the mismatch.
```

```text
Use the dotnet-pinvoke skill to diagnose a DllNotFoundException for this native library. Check library naming conventions for the target OS, suggest NativeLibrary.SetDllImportResolver for runtime resolution, and verify the native library is in the expected location.
```

---

## CsWin32 and Tooling

```text
Use the dotnet-pinvoke skill to set up CsWin32 for this project. I need P/Invoke declarations for the following Win32 APIs: [list APIs]. Show me how to install Microsoft.Windows.CsWin32 and configure NativeMethods.txt.
```

---

## Spargine-Style P/Invoke Review Prompt

```text
Use the dotnet-pinvoke skill to review the P/Invoke interop code in this Spargine library. Apply these constraints:

- Target is .NET 10 — use LibraryImport for all declarations, not DllImport.
- All native handles must use SafeHandle — no raw IntPtr escaping the interop layer.
- String encoding must be explicit — no CharSet.Auto.
- Memory ownership must be documented in XML doc comments for every method that crosses the boundary.
- CLong/CULong must be used for C long/unsigned long in any cross-platform declarations.
- Callbacks must use UnmanagedCallersOnly where possible; delegate-based callbacks must be explicitly rooted.
- All interop classes must be sealed and internal unless public access is required.
- Run the validation checklist and report every violation with a concrete fix.
```

---

## David-Ready P/Invoke Audit Prompt

```text
Use the dotnet-pinvoke skill to perform a full P/Invoke correctness audit on this .NET 10 interop code.

Report:
1. Type mapping issues — incorrect int/long for C long, ulong for size_t, bool without MarshalAs, BOOL mapped to bool.
2. String marshalling — missing or implicit encoding, CharSet.Auto usage, StringBuilder output buffers that should use Span<char> or char[].
3. Memory ownership violations — mismatched allocator/free pairs, unprotected callee-allocated buffers, incorrect pinning strategy.
4. SafeHandle gaps — raw IntPtr handles that should be wrapped in SafeHandle.
5. Callback safety — unrooted delegates, missing GC.KeepAlive after Marshal.GetFunctionPointerForDelegate.
6. Error handling — missing SetLastPInvokeError, unchecked HRESULTs.
7. Cross-platform issues — hardcoded library names without a resolver, CLong/CULong not used.
8. Migration opportunities — DllImport declarations that should be LibraryImport on .NET 10.

For each finding: location (file and declaration), explanation of the bug or risk, and a concrete before/after fix. End with the full validation checklist showing pass/fail for each item.
```
