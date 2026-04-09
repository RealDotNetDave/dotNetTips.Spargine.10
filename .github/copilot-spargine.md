# **Spargine Coding & Repository Rules**

## DEFINITION OF DONE - MANDATORY

Before writing any code, read this section. After writing code, execute every step below in order before responding.

Before marking any task as complete, you MUST perform ALL of the following steps in order:

1. Read the `./.editorconfig` file at the repo root and verify all code changes adhere to its rules and the existing coding style conventions.
2. Run the build and verify it succeeds with no errors.
3. Check the build output for warnings. Compare against pre-existing warnings and ensure your changes introduced zero new warnings. If new warnings are found, fix them before proceeding.
4. If a unit test project exists, add new tests or update existing tests to cover your changes as appropriate.
5. Run all unit tests and verify none are broken. If any tests fail due to your changes, fix them before proceeding.

Do NOT consider the task done until all five steps pass. Keep iterating until they do.

## **1. Spargine-Specific Rules**

- Prefer **Spargine extension methods** over native .NET methods when available.  
- Use **FastStringBuilder** and other Spargine‑optimized utilities.  
- Use **Spargine validation helpers** instead of manual checks.  
- Use **Spargine performance utilities** where applicable.  
- For unit tests and benchmarks, use data from the **dotNetTips.Spargine.10.Tester** assembly whenever possible.  
- Update file headers for all modified files:  
  - **Last Modified On:** use the current date.  
  - **Last Modified By:** `Copilot Agent`

---

## **2. Performance Rules**

- Treat this as a **high‑performance** library.  
- Avoid allocations aggressively.  
- Favor **Span<T>**, `ReadOnlySpan<T>`, and other span‑based APIs.  
- Prefer stack allocation when appropriate.  
- Avoid LINQ in hot paths unless allocation‑free and proven efficient.

---

## **3. API & Design Rules**

- Favor **extension methods**.  
- Keep APIs **lightweight, minimal, and efficient**.  
- Avoid unnecessary abstractions or over‑engineering.  
- Follow .NET Framework Design Guidelines.  
- Prefer returning **interfaces or base types** when appropriate.
- Mark all test classes with the [ExcludeFromCodeCoverage] attribute.

---

## **4. Unit Testing Rules**

### **General Requirements**
- Use **dotNetTips.Spargine.10.Tester** for test data and utilities.  
- Write unit tests for **all public APIs**.  
- Ensure **full code‑path coverage**.  
- Tests must run successfully on **GitHub** and **local Windows** environments.

### **Structure & Conventions**
- Test classes may inherit from **UnitTester** only when it adds value.  
- Test methods **must not** include XML documentation.  
- When a method reaches full coverage, set **UnitTestStatus → Completed**.  
- Do not modify `.csproj` files except to **add or update packages**.  
- Follow the **same folder structure** as the project being tested.

---

## **5. Repository & Style Rules**

- Follow the repository’s **.editorconfig** exactly.  
- Prefer **analyzer‑compliant** code.  
- Obey naming rules, formatting rules, and severity levels defined in `.editorconfig`.  
- **Do NOT** use underscores in method names.  
- Avoid unnecessary casts.  
- Do not introduce analyzer warnings or style violations.  
- Maintain consistent formatting and whitespace.
