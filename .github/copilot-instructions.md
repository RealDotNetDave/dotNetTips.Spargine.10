# **Spargine Coding & Repository Rules**

## DEFINITION OF DONE - MANDATORY

Before writing any code, read this section. After writing code, execute every step below in order before responding.

Before marking any task as complete, you MUST perform ALL of the following steps in order:

1. Update file headers in **every** modified `.cs` file: set **Last Modified On** to the current date (format `MM-DD-YYYY`) and **Last Modified By** to `Copilot Agent`.
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
  - Add `[UnconditionalSuppressMessage("Trimming", "IL20xx", Justification = "...")]` with a **meaningful justification** explaining why the suppression is safe. **Never** leave the justification as `"<Pending>"`.
  - Add `[DynamicallyAccessedMembers(...)]` to generic type parameters when the method constrains which members are accessed via reflection.
  - Fill in the `checkId` parameter (e.g., `"IL2026"`, `"IL2070"`) on all `[UnconditionalSuppressMessage]` attributes.

---
## **1.1. Spargine `[Information]` Attribute Rules**
- The `[Information]` attribute must be the last one if there are multiple attributes.
- When creating new methods, add an `[Information]` attribute with:
  - `UnitTestStatus = UnitTestStatus.None`
  - `OptimizationStatus = OptimizationStatus.Optimize`
  - `BenchmarkStatus = BenchmarkStatus.Benchmark`
  - `Status = Status.Available`
- After writing unit tests that fully cover a method, set `UnitTestStatus` to `UnitTestStatus.Completed`.
- After optimizing a method, update its `[Information]` attribute: set `OptimizationStatus` to `OptimizationStatus.Completed` and set `BenchmarkStatus` to `BenchmarkStatus.CheckPerformance` so benchmarks are re-validated against the new implementation.
- After creating a benchmark test for a method, update its `[Information]` attribute: set `BenchmarkStatus` to `BenchmarkStatus.CheckPerformance`.
- Every class-level `[Information]` attribute must include `Status = Status.Available` (or the appropriate `Status` value).
- All of the status properties in '[Information]' must be **ordered** as follows: `UnitTestStatus`, `OptimizationStatus`, `BenchmarkStatus`, `Status`. For example:
  ```csharp
  [Information(
	  UnitTestStatus = UnitTestStatus.Completed,
	  OptimizationStatus = OptimizationStatus.Completed,
	  BenchmarkStatus = BenchmarkStatus.CheckPerformance,
	  Status = Status.Available)]
  public sealed class MyClass { ... }
  ```'

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
- **Always use proper attributes** for any method that includes attributes for performance. Remove unnecessary attributes.
- Mark **side‑effect‑free** methods with `[Pure]` (from `System.Diagnostics.Contracts`).  
- Use **nullability attributes** on parameters and return types: `[DisallowNull]` for non‑nullable inputs, `[AllowNull]` for nullable inputs, `[NotNull]` / `[return: NotNull]` for guaranteed non‑null returns.  
- **All public source members** (classes, methods, properties) must have full **XML documentation** (`<summary>`, `<param>`, `<returns>`, `<exception>`, and `<remarks>` where appropriate). Test methods are exempt.

---

## **4. Unit Testing Rules**

### **General Requirements**
- The test framework is **MSTest** (`[TestClass]`, `[TestMethod]`). Do not use xUnit or NUnit.  
- Use **dotNetTips.Spargine.10.Tester** for test data and utilities — specifically **`RandomData`** for generating random test data and **`PersonData`** for person-related data.  
- Write unit tests for **all public APIs**.
- If methods are new or modified, ensure they are covered by unit tests.
- Ensure **full code‑path coverage**. **THIS IS MANDATORY!**
- Tests must run successfully on **GitHub** and **local Windows** environments.
- Do not add code comments between methods, only in unit test methods. 
- Mark all test classes with the `[ExcludeFromCodeCoverage]` attribute.
- Review all methods in a test class for issues.

### **Structure & Conventions**
- Test classes may inherit from **UnitTester** only when it adds value.  
- Test methods **must not** include XML documentation.  
- Name test methods using **`Method_Condition_ExpectedBehavior`** (e.g., `ArgumentCountInRange_CountAboveMax_ThrowsArgumentOutOfRangeException`).  
- When a method reaches full coverage, set **UnitTestStatus → Completed**.  
- Do not modify `.csproj` files except to **add or update packages**.  
- Follow the **same folder structure** as the project being tested.

---

## **5. Repository & Style Rules**

- **Preserve the Spargine banner comment** in every `.cs` file. It must appear between the `using` directives and the `namespace` declaration:
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
