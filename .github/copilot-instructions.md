# **Spargine Coding & Repository Rules**

## DEFINITION OF DONE - MANDATORY!

Before writing any code, read this section. After writing code, execute every step below in order before responding.

Before marking any task as complete, you MUST perform ALL of the following steps in order:

1. Update file headers in **every** modified `.cs` file: set **Last Modified On** to the current date (format `MM-DD-YYYY`) and **Last Modified By** to `Copilot Agent`. **Always obtain the real current date by running `Get-Date -Format 'MM-dd-yyyy'` in the terminal. Never hard-code or fabricate a date.**
2. Read the `./.editorconfig` file at the repo root and verify all code changes adhere to its rules and the existing coding style conventions.
3. Run the build and verify it succeeds with no errors.
4. Check the build output for warnings. Compare against pre-existing warnings and ensure your changes introduced zero new warnings. If new warnings are found, fix them before proceeding.
5. If a unit test project exists, add new tests or update existing tests to cover your changes as appropriate.
6. Run all unit tests and verify none are broken. If any tests fail due to your changes, fix them before proceeding.

Do NOT consider the task done until all six steps pass. Keep iterating until they do.

## **1. Spargine-Specific Rules**

- Prefer **Spargine extension methods** over native .NET methods when available.  
- Use **FastStringBuilder** and other Spargine‑optimized utilities.  
- Use **`ControlChars`** constants (e.g., `ControlChars.EmptyString`, `ControlChars.Space`, `ControlChars.Comma`) instead of literal strings and characters such as `""`, `' '`, or `','`.  
- Use **`ExceptionThrower`** methods (e.g., `ExceptionThrower.ThrowArgumentNullException()`) to throw exceptions instead of `throw new …`.  
- Use **`Validator.Argument*`** extension methods for parameter validation (e.g., `input.ArgumentNotNull()`, `input.ArgumentCountInRange(min, max)`). These validate **and return** the input for fluent chaining.  
- Use **`Validator.Check*`** extension methods for conditional checks (e.g., `fileInfo.CheckExists(throwException: true)`). These return `bool` and optionally throw. **Do NOT confuse** the two families: `Argument*` = validate parameters and return the value; `Check*` = return true/false.  
- Use **resource strings** from `Properties/Resources` for error messages (never hard‑code user‑facing error text inline). Reference them via `Resources.ErrorXxx`.  
- Use **Spargine performance utilities** where applicable.
- For unit tests and benchmarks, use data from the **dotNetTips.Spargine.10.Tester** assembly whenever possible.  
- Update file headers for **all** modified files:  
  - **Last Modified On:** use the current date in `MM-DD-YYYY` format.  
  - **Last Modified By:** `Copilot Agent`  
  - Use the correct **current date** for "Created" and "Last Modified On" fields. Do not use incorrect or fabricated dates.
- When adding or removing methods and properties to a class, update the `<summary>` XML tag in the file header.
- When creating a **new file**, use this exact header template:
  ```
  // ***********************************************************************
  // Assembly         : <AssemblyName>
  // Author           : Copilot Agent
  // Created          : <MM-DD-YYYY>
  //
  // Last Modified By : Copilot Agent
  // Last Modified On : <MM-DD-YYYY>
  // ***********************************************************************
  // <copyright file="<FileName>.cs" company="dotNetTips.com - McCarter Consulting">
  //     McCarter Consulting (David McCarter)
  // </copyright>
  // <summary>
  // <Brief description of the class/type.>
  // </summary>
  // ***********************************************************************
  ```
- **Trimming attributes** — when code uses reflection or calls methods that do:
  - Add `[RequiresUnreferencedCode("...")]` with a **descriptive, method-specific message** explaining *what* reflection the method performs (e.g., `"Enumerates assembly types via Assembly.GetTypes()."` or `"Uses XmlSerializer which requires unreferenced code for type metadata."`). **Never** use the generic default message `"This method uses reflection to discover types at runtime."`.
  - Add `[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "...")]` with a **meaningful justification** explaining why the suppression is safe. **Never** leave the justification as `"<Pending>"`. Replace `"IL2026"` with the actual diagnostic ID that applies (e.g., `"IL2026"`, `"IL2070"`, `"IL2067"`).
  - Add `[DynamicallyAccessedMembers(...)]` to generic type parameters when the method constrains which members are accessed via reflection.
  - Fill in the `checkId` parameter (e.g., `"IL2026"`, `"IL2070"`) on all `[UnconditionalSuppressMessage]` attributes.

---
## **1.2. Trim-Safe Code Requirements (MANDATORY)**

**This library is trim-compatible. All code MUST be trim-safe by default.**

### **Core Principle**
- **AVOID reflection whenever possible.** Prefer compile-time solutions (source generators, static methods, known types).
- **If reflection is unavoidable**, annotate properly and ensure the trimmer can preserve required members.

### **Trim-Safe Patterns (PREFER THESE)**
- Use **generic constraints** with known types instead of `typeof()` or `GetType()` on unknown types.
- Use **source generators** instead of runtime reflection (e.g., `System.Text.Json` source gen, `Regex` source gen).
- Use **compile-time known types** and direct method calls instead of `Activator.CreateInstance()` or `MethodInfo.Invoke()`.
- Use **static methods** or **delegates** instead of dynamically discovering and invoking methods.
- For serialization, prefer `System.Text.Json` with source generators over reflection-based serializers.
- For collections, use concrete types (`List<T>`, `T[]`) instead of `IEnumerable<T>` when possible to avoid LINQ reflection.

### **Trim-Unsafe Patterns (AVOID OR ANNOTATE)**
- **`Assembly.GetTypes()`**, `Assembly.GetExportedTypes()` — requires all types in the assembly to be preserved.
  - If unavoidable: add `[RequiresUnreferencedCode("Enumerates all types in assembly via Assembly.GetTypes().")]`.
- **`Type.GetProperties()`**, `Type.GetMethods()`, `Type.GetFields()` without constraints — may require entire type graphs.
  - If unavoidable: add `[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]` (or the specific member types needed) to the `Type` parameter or generic constraint.
- **`Activator.CreateInstance(Type)`** — requires preserving constructors.
  - Prefer: `new T()` with `where T : new()` constraint, or source-generated factory methods.
  - If unavoidable: add `[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]`.
- **`MethodInfo.Invoke()`**, `PropertyInfo.GetValue()`/`SetValue()` — requires preserving members.
  - Prefer: compile-time delegates or expression trees compiled once.
  - If unavoidable: annotate the source of the `MethodInfo`/`PropertyInfo` with `[DynamicallyAccessedMembers(...)]`.
- **LINQ to Objects over `IEnumerable<T>` from reflection** — may trigger trim warnings.
  - Prefer: materialize to `T[]` or `List<T>` first, or use direct iteration.
- **JSON/XML serializers without source generation** — `XmlSerializer`, `BinaryFormatter`, older JSON libraries.
  - Prefer: `System.Text.Json` with `[JsonSerializable]` source generator.
  - If unavoidable: add `[RequiresUnreferencedCode("Uses XmlSerializer which requires unreferenced code for type metadata.")]`.

### **Annotation Strategy (When Reflection Is Required)**
1. **Method-level**: Add `[RequiresUnreferencedCode("...")]` with a specific, descriptive message.
2. **Parameter/Generic-level**: Add `[DynamicallyAccessedMembers(...)]` to the `Type` parameter or generic type parameter.
3. **Suppression**: Only use `[UnconditionalSuppressMessage]` when you have verified the code is trim-safe despite the warning (e.g., you know the types are preserved elsewhere). **Always** provide a meaningful `Justification`.

### **Trim Warning Enforcement**
- **Zero trim warnings** must be introduced by new code.
- Run the build and check for `IL2026`, `IL2060-IL2099` warnings after writing or modifying code.
- If a trim warning appears, **first try to eliminate it** by refactoring to a trim-safe pattern.
- Only if refactoring is impractical, add the appropriate attributes (`[RequiresUnreferencedCode]`, `[DynamicallyAccessedMembers]`, or justified `[UnconditionalSuppressMessage]`).

### **Examples**

#### ❌ Trim-Unsafe (avoid)
```csharp
public void ProcessType(Type type)
{
    var properties = type.GetProperties(); // IL2070: requires all properties preserved
    foreach (var prop in properties)
    {
        var value = prop.GetValue(instance); // may fail when trimmed
    }
}
```

#### ✅ Trim-Safe (annotated)
```csharp
public void ProcessType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] Type type)
{
    var properties = type.GetProperties(); // trimmer preserves public properties
    foreach (var prop in properties)
    {
        var value = prop.GetValue(instance);
    }
}
```

#### ✅ Trim-Safe (refactored to avoid reflection)
```csharp
public void ProcessType<T>(T instance) where T : IHasProperties
{
    var properties = instance.GetPropertiesViaInterface(); // compile-time known
    foreach (var prop in properties)
    {
        var value = prop.Value; // no reflection
    }
}
```

---
## **1.1. Spargine `[Information]` Attribute Rules**
- The `[Information]` attribute must be the last one if there are multiple attributes.
- The **first parameter** of `[Information]` must always be the description string. Use `nameof()` to reference the method name whenever possible (e.g., `[Information(nameof(MyMethod), ...)]`). For class-level attributes where `nameof()` is not applicable, provide a meaningful description string.
- When creating new methods, add an `[Information]` attribute with:
  - Description as the first positional argument using `nameof()` (e.g., `nameof(MyMethod)`)
  - `UnitTestStatus = UnitTestStatus.None`
  - `OptimizationStatus = OptimizationStatus.Optimize`
  - `BenchmarkStatus = BenchmarkStatus.Benchmark`
  - `Status = Status.Available`
- After writing unit tests that fully cover a method, set `UnitTestStatus` to `UnitTestStatus.Completed`.
- After optimizing a method, update its `[Information]` attribute: set `OptimizationStatus` to `OptimizationStatus.Completed` and set `BenchmarkStatus` to `BenchmarkStatus.CheckPerformance` so benchmarks are re-validated against the new implementation.
- After creating a benchmark test for a method, update its `[Information]` attribute: set `BenchmarkStatus` to `BenchmarkStatus.CheckPerformance`.
- Every class-level `[Information]` attribute must include `Status = Status.Available` (or the appropriate `Status` value).
  - ALWAYS align all named property assignments vertically (tab-indent each named property on its own line so the `=` signs line up), as shown in the example below.
- If code in a method is modified and the `[Information]` attribute `BenchmarkStatus` is set to `BenchmarkStatus.Completed`, update it to `BenchmarkStatus.CheckPerformance` to indicate that benchmarks must be re-validated.
- All of the status properties in '[Information]' must be **ordered** as follows: `UnitTestStatus`, `OptimizationStatus`, `BenchmarkStatus`, `Status`. For example:
  ```csharp
  [Information(nameof(MyMethod),
	  UnitTestStatus = UnitTestStatus.Completed,
	  OptimizationStatus = OptimizationStatus.Completed,
	  BenchmarkStatus = BenchmarkStatus.CheckPerformance,
	  Status = Status.Available)]
  public void MyMethod() { ... }

  // For class-level attributes (nameof() not applicable), use a descriptive string:
  [Information("MyClass description.",
	  UnitTestStatus = UnitTestStatus.Completed,
	  OptimizationStatus = OptimizationStatus.Completed,
	  BenchmarkStatus = BenchmarkStatus.CheckPerformance,
	  Status = Status.Available)]
  public sealed class MyClass { ... }
  ```

---

## **1.3. Resource String Formatting (MANDATORY)**

- **NEVER** pass a resource string directly to `string.Format()` or `StringBuilder.AppendFormat()`.
- **ALWAYS** pre-parse resource format strings into `CompositeFormat` instances cached as `private static readonly` fields.
- Name `CompositeFormat` fields after the resource key using camelCase with `_` prefix: `Resources.RangeError` → `_rangeError`.
- Use `string.Format(CultureInfo.InvariantCulture, _compositeField, args)` or the appropriate culture overload.

```csharp
// ❌ BAD — re-parses on every call (CA1863)
string message = string.Format(CultureInfo.InvariantCulture, Resources.RangeError, min, max);

// ✅ GOOD — parse once, reuse
private static readonly CompositeFormat _rangeError = CompositeFormat.Parse(Resources.RangeError);
string message = string.Format(CultureInfo.InvariantCulture, _rangeError, min, max);
```

---

## **2. Performance Rules**

- Treat this as a **high‑performance** library.  
- Avoid allocations aggressively.  
- Favor **Span<T>**, `ReadOnlySpan<T>`, and other span‑based APIs.  
- Prefer stack allocation when appropriate.  
- Avoid LINQ in hot paths unless allocation‑free and proven efficient.
- **DO NOT** suggest performance optimizations unless the code is benchmarked before and after the change.

---

## **3. API & Design Rules**

- Favor **extension methods**.  
- The **Extensions project** uses **C# 14 extension blocks** (`extension<T>(...) { }`) instead of traditional `this` extension methods. When adding new extension methods in `DotNetTips.Spargine.10.Extensions`, use this syntax:
  ```csharp
  extension<T>([DisallowNull] T[] array)
  {
      [Pure]
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      [Information(...)]
      public T[] MyMethod() { ... }
  }
  ```
- Add **`[MethodImpl(MethodImplOptions.AggressiveInlining)]`** to all public and internal methods.  
- Keep APIs **lightweight, minimal, and efficient**.
- **Seal classes by default.** All concrete classes must be `sealed` unless inheritance is explicitly required (e.g., `Person`, `Address`, `Singleton<T>`, exception types are all sealed).  
- Avoid unnecessary abstractions or over‑engineering.  
- Follow .NET Framework Design Guidelines.  
- Prefer returning **interfaces or base types** when appropriate.
- **Always use proper attributes** for any method that includes attributes for performance. Remove unnecessary attributes that do not apply (e.g., do not add `[Pure]` to a method with side effects, do not add `[MethodImpl(AggressiveInlining)]` to async methods).
- Mark **side‑effect‑free** methods with `[Pure]` (from `System.Diagnostics.Contracts`).  
- Use **nullability attributes** on parameters and return types: `[DisallowNull]` for non‑nullable inputs, `[AllowNull]` for nullable inputs, `[NotNull]` / `[return: NotNull]` for guaranteed non‑null returns.  
- **All members** (classes, methods, properties) must have full **XML documentation** (`<summary>`, `<param>`, `<returns>`, `<exception>`, and `<remarks>` where appropriate). Test methods are exempt.

---

## **4. Benchmarking Rules**

- All benchmarks use **BenchmarkDotNet** via the `DotNetTips.Spargine.Benchmarking` assembly.
- Benchmark classes inherit from one of: `Benchmark`, `CollectionBenchmark`, `SmallCollectionBenchmark`, `LargeCollectionBenchmark`, `TinyCollectionBenchmark`, or `CounterBenchmark`.
- **Override `Setup()`** (not `[GlobalSetup]`) in derived benchmark classes; the base `Benchmark` class owns `[GlobalSetup]` which calls `Setup()`. Always call `base.Setup()` first.
- Do not declare `[GlobalSetup]` methods in derived classes — they will conflict with the base class.
- **Never suggest or apply performance optimizations** unless benchmarked before and after the change.
- After optimizing a method, update its `[Information]` attribute to `BenchmarkStatus = BenchmarkStatus.CheckPerformance`.
- Do NOT declare field initializers as `= null!`; leave them without an initializer if they are set in `Setup()`.

---

## **5. Unit Testing Rules**

### **General Requirements**
- The test framework is **MSTest**
- Use **dotNetTips.Spargine.10.Tester** for test data and utilities — specifically **`RandomData`** for generating random test data and **`PersonData`** for person-related data.  
- Write unit tests for **all public and protected APIs**.
- If methods are new or modified, ensure they are covered by unit tests.
- Ensure **full code‑path coverage**. **THIS IS MANDATORY!**
    - CRAP score for public and protected methods must be 5 or under.
    - **Maintainability Index** for every method must be **50 or above** (minimum); **80 or above** is the target. If a method falls below 50, refactor it before considering the task done.
- Tests must run successfully on **GitHub** and **local Windows** environments.
- Do not add code comments between methods, only in unit test methods. 
- Mark all test classes with the `[ExcludeFromCodeCoverage]` attribute.
- Review all methods in a test class for: missing test coverage, incorrect assertions, hard-coded values that should use `RandomData`, missing `[ExpectedException]` or `Assert.ThrowsException` for error paths, and any violations of the naming convention.
- ALWAYS run unit tests after writing or modifying code. If any test fails, fix it before considering the task done.

#### **Structure & Conventions**
- Test classes may inherit from **UnitTester** only when it adds value.  
- Test methods **must not** include XML documentation.  
- Name test methods using **`Method_Condition_ExpectedBehavior`** (e.g., `ArgumentCountInRange_CountAboveMax_ThrowsArgumentOutOfRangeException`).  
- When a method reaches full coverage, set **UnitTestStatus → Completed**.  
- Do not modify `.csproj` files except to **add or update packages**.  
- Follow the **same folder structure** as the project being tested.

---

## **6. Repository & Style Rules**

- **Preserve the Spargine banner comment**
  ```
  //'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
  ```
  Do NOT remove, modify, or reformat this line.
- Follow the repository’s **.editorconfig** exactly.  
- Prefer **analyzer‑compliant** code.  
- Obey naming rules, formatting rules, and severity levels defined in `.editorconfig`.  
- **Do NOT** use underscores in method names.  
- Avoid unnecessary casts.  
- Do not introduce analyzer warnings or style violations.  
- Maintain consistent formatting and whitespace.
- Always use **file‑scoped namespaces** (`namespace X;`), not block‑scoped.  
- **Namespace convention** — namespaces omit the `10` from project names. Map project → namespace:  
  - `DotNetTips.Spargine.10.Core` → `DotNetTips.Spargine.Core`  
  - `DotNetTips.Spargine.10.Extensions` → `DotNetTips.Spargine.Extensions`  
  - `DotNetTips.Spargine.10.Tester` → `DotNetTips.Spargine.Tester`  
- **Partial class file naming** — when splitting a class across files, name each file `ClassName.Purpose.cs` (e.g., `Validator.Argument.cs`, `Validator.Check.cs`, `ExceptionThrower.Create.cs`, `RegexProcessor.Methods.cs`).

---
## **7. Redundant Parameter Validation**

When writing or reviewing extension methods, **do NOT add a null guard for the primary collection or sequence parameter if the downstream API already throws `ArgumentNullException` for that same parameter.** Adding a redundant check bloats the method body and misrepresents where the validation actually occurs.

### **Decision rule**
Before adding `param = param.ArgumentNotNull()`, verify what the first downstream call does with that parameter:

- **BCL method validates null → remove the guard.** The BCL throws the same `ArgumentNullException`; the pre-check adds no value.
- **Internal helper / constructor silently accepts null (returns empty, uses `?.`, etc.) → keep the guard.** Removing it would change the exception type from `ArgumentNullException` to `NullReferenceException`, or silently swallow a programming error.
- **Manual iteration (`foreach`) follows immediately → keep the guard.** A null collection causes `NullReferenceException`, not `ArgumentNullException`.

### **Known BCL APIs that already validate null on their source/collection parameter**

| API | Throws |
|---|---|
| `Enumerable.Chunk(source, size)` | `ArgumentNullException` |
| `Enumerable.Shuffle(source)` | `ArgumentNullException` |
| `Enumerable.TryGetNonEnumeratedCount(source, ...)` | `ArgumentNullException` |
| `FrozenSet.ToFrozenSet(source, comparer)` | `ArgumentNullException` (via `ArgumentNullException.ThrowIfNull`) |
| `new List<T>(IEnumerable<T> collection)` | `ArgumentNullException` |
| `new LinkedList<T>(IEnumerable<T> collection)` | `ArgumentNullException` |
| `new FastSortedList<T>(IEnumerable<T> collection, ...)` | `ArgumentNullException` (chains to `List<T>(IEnumerable<T>)`) |

### **Known APIs that do NOT validate null (keep the guard)**

| API / pattern | Behavior on null |
|---|---|
| `CollectionsMarshal.AsSpan(List<T>? list)` | Returns empty `Span<T>` — no exception |
| `DistinctBlockingCollection<T>(IEnumerable<T>)` | Null-conditional `collection?.FastLongCount()` — silent no-op |
| Collection expression `[.. source]` | Iterates `source` → `NullReferenceException` |
| `foreach` directly on parameter | `NullReferenceException` |
| Internal helpers that assume prior validation | Undefined / `NullReferenceException` |

### ❌ Bad — redundant guard
```csharp
public IEnumerable<IEnumerable<T>> Partition(int pageCount)
{
    collection = collection.ArgumentNotNull(); // redundant: Enumerable.Chunk validates this
    return collection.Chunk(pageCount);
}
```

### ✅ Good — guard removed; BCL owns the contract
```csharp
public IEnumerable<IEnumerable<T>> Partition(int pageCount)
{
    pageCount = pageCount.EnsureMinimum(2);
    return collection.Chunk(pageCount);
}
```

---
## **8. Protected / Auto-Generated Files**

- **NEVER modify any file under `docs/Library Information/`**. These markdown files (`*.info.md`) are auto-generated by a unit test at build time. Any changes you make will be overwritten and must not be committed. These files are excluded from git tracking via `.gitignore`.
