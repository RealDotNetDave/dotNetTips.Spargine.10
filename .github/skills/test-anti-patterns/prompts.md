# Copilot Prompts for the `test-anti-patterns` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/test-anti-patterns/skill.md`

This skill performs a quick, pragmatic detection-focused review of .NET test code for anti-patterns that undermine reliability and diagnostic value. It covers assertion gaps, swallowed exceptions, always-true assertions, flakiness indicators, test coupling, over-mocking, naming issues, magic values, duplicate tests, and structural problems — with severity-ranked findings and targeted remediation guidance. Works with MSTest, xUnit, NUnit, and TUnit.

---

## General Test Quality Audit

```text
Use the test-anti-patterns skill to review this test file. Check all anti-pattern categories — assertions, isolation, flakiness, naming, structure, and hygiene. Report findings grouped by severity (Critical / High / Medium / Low), include specific locations and concrete fixes for all Critical and High findings, and call out what the tests do well.
```

```text
Use the test-anti-patterns skill to audit the test project. I want a severity-ranked report of every anti-pattern found, positive observations about what the tests do well, and a prioritized fix list starting with Critical issues.
```

---

## Assertion Quality

```text
Use the test-anti-patterns skill to review the assertions in this test file. Find any test methods with no assertions, always-true assertions (Assert.IsTrue(true), Assert.AreEqual(x, x)), commented-out assertions, or assertions that live inside catch blocks instead of using Assert.ThrowsException.
```

```text
Use the test-anti-patterns skill to find tests that give false confidence in this file. Focus on no-assertion tests, swallowed exceptions, and conditions that can never fail. Report each with its exact location and a concrete before/after fix.
```

---

## Swallowed Exceptions and Error Paths

```text
Use the test-anti-patterns skill to find swallowed exceptions in this test project. Look for empty catch blocks, catch blocks that only call Assert.Fail, and try/catch patterns that should be replaced with Assert.ThrowsException or Assert.ThrowsExactly.
```

```text
Use the test-anti-patterns skill to audit error-path testing in this file. Find every place where an exception is expected but not properly asserted, including [ExpectedException] usage and broad Exception assertions instead of specific exception types.
```

---

## Flakiness

```text
Use the test-anti-patterns skill to identify flakiness indicators in this test project. Look for Thread.Sleep and Task.Delay used for synchronization, DateTime.Now or DateTime.UtcNow without abstraction, unseeded Random usage, and environment-dependent file paths.
```

```text
Use the test-anti-patterns skill to find tests that may pass locally but fail in CI. Focus on timing dependencies, static mutable shared state, test ordering dependencies, and environment-specific assumptions.
```

---

## Test Isolation and Coupling

```text
Use the test-anti-patterns skill to find test ordering dependencies in this file. Look for static mutable fields modified across tests, [TestInitialize] methods that do not fully reset state, and any shared state that could cause a test to pass or fail depending on execution order.
```

```text
Use the test-anti-patterns skill to find implementation coupling in these tests. Look for tests that access private methods via reflection, assert on internal state instead of observable behavior, and verify exact method call counts on collaborators rather than outcomes.
```

```text
Use the test-anti-patterns skill to review test isolation. Identify any tests that fail when run individually but pass in the full suite (or vice versa), and pinpoint the shared state causing the coupling.
```

---

## Over-Mocking

```text
Use the test-anti-patterns skill to identify over-mocking in this test file. Flag any test where mock setup lines outnumber the actual test logic, where exact call sequences are verified instead of outcomes, and where types the test owns are being mocked unnecessarily.
```

---

## Naming

```text
Use the test-anti-patterns skill to review test naming in this file. Find any test methods named Test1, TestMethod, or names that do not describe the scenario and expected outcome. Suggest corrected names using the MethodName_Scenario_ExpectedBehavior convention.
```

```text
Use the test-anti-patterns skill to check naming consistency in this test class. Flag any mix of naming styles (some tests use Method_Scenario_Expected, others use ShouldDoSomething) and recommend a single consistent convention.
```

---

## Magic Values and Duplicate Tests

```text
Use the test-anti-patterns skill to find magic values in this test file. Report every unexplained number or string in arrange or assert sections where the significance of the value is not clear from the code alone.
```

```text
Use the test-anti-patterns skill to find duplicate tests that should be converted to data-driven tests. Flag groups of three or more test methods with near-identical bodies that differ only in a single input value, and suggest the [DataRow], [Theory], or [TestCase] equivalent.
```

---

## Structure and Size

```text
Use the test-anti-patterns skill to find oversized tests in this file. Flag any test methods exceeding approximately 30 lines or testing multiple behaviors in a single method, and suggest how to split them.
```

```text
Use the test-anti-patterns skill to check AAA structure in this test class. Identify tests where the Arrange, Act, and Assert phases are interleaved or indistinguishable, and suggest how to clarify the separation.
```

---

## Hygiene

```text
Use the test-anti-patterns skill to find hygiene issues in this test file. Look for unused [TestInitialize] or [SetUp] methods, IDisposable objects not wrapped in using statements, leftover Console.WriteLine or Debug.WriteLine debugging statements, and dead test helper methods that are never called.
```

---

## Focused Single-Category Review

```text
Use the test-anti-patterns skill to review only flakiness in this test project. I want a focused report on timing dependencies, shared state, and environment assumptions — nothing else.
```

```text
Use the test-anti-patterns skill to focus only on naming issues in this test file. Do not report assertion or isolation issues — I just want naming findings and suggested fixes.
```

```text
Use the test-anti-patterns skill to focus only on Critical and High severity findings in this project. Skip Medium and Low issues for now.
```

---

## Spargine-Style Test Anti-Pattern Review

```text
Use the test-anti-patterns skill to review this Spargine test project. Apply these priorities:

- Critical: Any test with no assertions, swallowed exceptions, or always-true conditions.
- High: Flakiness from Thread.Sleep, DateTime.Now without abstraction, or static shared state. Broad Exception assertions instead of specific types.
- Medium: Test names that do not follow MethodName_Scenario_ExpectedBehavior. Magic values with no context. Groups of 3+ near-identical tests that should be data-driven.
- Low: Unused [TestInitialize] methods, IDisposable not disposed, leftover debug output.

Report Critical and High findings with specific file and method locations and concrete before/after fixes. Summarize Medium and Low in a table. Call out positive patterns — sealed test classes, [ExcludeFromCodeCoverage], specific exception types, clear AAA structure, proper use of RandomData from the Tester assembly. End with a prioritized fix list.
```

---

## David-Ready Test Anti-Pattern Audit Prompt

```text
Use the test-anti-patterns skill to perform a full anti-pattern audit on this .NET 10 test project.

Report:
1. Summary — total findings by severity (Critical / High / Medium / Low). If the tests are well-written, say so up front.
2. Critical findings — no assertions, swallowed exceptions, always-true assertions, commented-out assertions, assert-in-catch-only. Each with file, method, line, explanation, and before/after fix.
3. High findings — flakiness indicators, test ordering dependencies, over-mocking, implementation coupling, broad exception assertions. Each with file, method, line, explanation, and concrete fix.
4. Medium and Low findings — summarized in a table (pattern, location, suggested fix).
5. Positive observations — what the tests do well (specific patterns, not generic praise).
6. Prioritized fix list — Critical first, then High, then Medium/Low opportunistically.

Do not inflate severity. A finding is Critical only if it causes false confidence. A finding is High only if it causes flakiness or serious maintenance burden. If tests are clean, report that clearly.
```
