# Copilot Prompts for the `csharp-mstest` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/csharp-mstest/skill.md`

This skill covers modern MSTest 3.x/4.x best practices including test class structure, lifecycle hooks, assertion APIs, data-driven tests, `TestContext` usage, and advanced features such as retry, OS conditions, parallelization, and work item traceability.

---

## General Test Review

```text
Use the csharp-mstest skill to review this test file for MSTest best practices. Check class structure, naming conventions, lifecycle usage, assertion correctness, data-driven patterns, and common mistakes. Report all findings with line references and concrete fixes.
```

```text
Use the csharp-mstest skill to audit the test project for outdated or incorrect MSTest usage. I want a prioritized list of issues grouped by severity: correctness issues first, then modernization opportunities, then style issues.
```

---

## Test Class Structure and Naming

```text
Use the csharp-mstest skill to check all test classes in this file for correct structure. Verify that each class uses [TestClass], is sealed, uses the MethodName_Scenario_ExpectedBehavior naming convention, and follows the Arrange-Act-Assert pattern.
```

```text
Use the csharp-mstest skill to find test methods in this project that do not follow the MethodName_Scenario_ExpectedBehavior naming convention. List each violation and suggest a corrected name based on what the test appears to be verifying.
```

---

## Test Lifecycle

```text
Use the csharp-mstest skill to review the test lifecycle hooks in this file. Flag any [TestInitialize] methods that should be converted to constructors, any async setup that requires [TestInitialize], and any cleanup that could use [TestCleanup] or IDisposable instead.
```

```text
Use the csharp-mstest skill to check whether constructor injection is used correctly for test class setup. Flag any [TestInitialize] methods that only contain synchronous setup code and should be replaced with a constructor to enable readonly fields.
```

---

## Assertions

```text
Use the csharp-mstest skill to review all assertions in this test file. Flag incorrect argument order in Assert.AreEqual calls, [ExpectedException] usage that should be replaced with Assert.Throws or Assert.ThrowsExactly, and any assertion that could use a more specific modern API.
```

```text
Use the csharp-mstest skill to modernize the assertions in this test file. Replace [ExpectedException] with Assert.Throws, replace LINQ Single() with Assert.ContainsSingle, replace hard casts with Assert.IsInstanceOfType, and replace StringAssert/CollectionAssert calls where an equivalent Assert class API exists.
```

```text
Use the csharp-mstest skill to find all Assert.AreEqual calls in this file and verify the argument order is (expected, actual). Report and fix any that have the arguments reversed.
```

---

## Exception Testing

```text
Use the csharp-mstest skill to find all [ExpectedException] attributes in this test project and convert them to Assert.Throws or Assert.ThrowsExactly. Use Assert.ThrowsExactly when the test must match the exact exception type and Assert.Throws when derived types are acceptable.
```

```text
Use the csharp-mstest skill to review exception testing in this file. Verify that every error path in the production code has a corresponding test using Assert.Throws or Assert.ThrowsAsync, and that exception messages and properties are validated after catching.
```

---

## Collection and String Assertions

```text
Use the csharp-mstest skill to review collection assertions in this file. Replace CollectionAssert usage with the modern Assert class equivalents where available (Assert.Contains, Assert.IsEmpty, Assert.HasCount, Assert.ContainsSingle). Flag any remaining CollectionAssert calls that have no modern equivalent.
```

```text
Use the csharp-mstest skill to review string assertions in this file. Replace StringAssert usage with Assert.Contains, Assert.StartsWith, Assert.EndsWith, Assert.MatchesRegex where applicable, and flag any StringAssert calls that have no direct Assert equivalent.
```

---

## Data-Driven Tests

```text
Use the csharp-mstest skill to review data-driven tests in this file. Upgrade any [DynamicData] sources using IEnumerable<object[]> to use ValueTuple or TestDataRow for type safety. Flag any [DataRow] tests that should be consolidated into a single [DynamicData] method.
```

```text
Use the csharp-mstest skill to review [DataRow] usage in this test class. Identify test methods with many [DataRow] attributes that would benefit from a typed DynamicData source using IEnumerable<(T1, T2, ...)> ValueTuples, and suggest the refactored version.
```

```text
Use the csharp-mstest skill to find all IEnumerable<object[]> DynamicData sources in this project and convert them to typed ValueTuple sources for compile-time type safety.
```

---

## TestContext Usage

```text
Use the csharp-mstest skill to review TestContext usage in this test file. Check that TestContext is injected via constructor (preferred over property injection in MSTest 3.6+), that TestContext.CancellationToken is used in async tests with [Timeout], and that TestContext is not declared as nullable or initialized with null!.
```

```text
Use the csharp-mstest skill to find async test methods in this project that use [Timeout] but do not pass TestContext.CancellationToken to awaited calls. Report each location and show the corrected method signature and call.
```

---

## Cancellation and Timeout

```text
Use the csharp-mstest skill to audit all async test methods in this file for proper cancellation support. Every async test with [Timeout] must forward TestContext.CancellationToken to downstream awaited calls. Flag any that use CancellationToken.None or omit the token entirely.
```

---

## Parallelization

```text
Use the csharp-mstest skill to review parallelization setup in this test project. Check whether [assembly: Parallelize] is configured appropriately and whether any test classes that share mutable state are missing [DoNotParallelize].
```

---

## Advanced Features

```text
Use the csharp-mstest skill to identify flaky tests in this project and apply [Retry(3)] (MSTest 3.9+) to tests that are known to be non-deterministic. Explain why each test is a candidate for retry and whether the underlying flakiness should be fixed instead.
```

```text
Use the csharp-mstest skill to review OS-specific and CI-specific tests in this project. Add [OSCondition] to tests that only apply to certain platforms and [CICondition] to tests that should only run in a CI environment. Report tests that are currently being skipped manually with Assert.Inconclusive that could use these attributes instead.
```

```text
Use the csharp-mstest skill to add [GitHubWorkItem] or [WorkItem] traceability attributes to tests in this file that correspond to known issues or feature requests. Link each test to the appropriate issue number.
```

---

## Spargine-Style MSTest Review Prompt

```text
Use the csharp-mstest skill to review this Spargine test project. Apply these rules strictly:

- All test classes must be sealed and marked [ExcludeFromCodeCoverage].
- Test methods must use the MethodName_Scenario_ExpectedBehavior naming convention.
- No [ExpectedException] — use Assert.Throws or Assert.ThrowsExactly.
- Assert.AreEqual argument order must be (expected, actual).
- [DynamicData] sources must use ValueTuple or TestDataRow — no IEnumerable<object[]>.
- [TestInitialize] should only be used for async setup; synchronous setup belongs in constructors.
- Async tests with [Timeout] must forward TestContext.CancellationToken.
- TestContext must not be declared nullable or initialized with null!.
- Use Assert class equivalents instead of StringAssert or CollectionAssert where available.
- All public and protected methods under test must have full coverage (CRAP score ≤ 5).

Report findings by severity, include exact file and line references, and provide a concrete fix for each issue.
```

---

## David-Ready MSTest Audit Prompt

```text
Use the csharp-mstest skill to perform a full MSTest 3.x/4.x best-practices audit on this .NET 10 test project.

Report:
1. Structural violations — unsealed classes, missing [TestClass]/[TestMethod], naming convention violations.
2. Lifecycle issues — [TestInitialize] that should be constructors, missing [TestCleanup] for resources.
3. Assertion problems — reversed Assert.AreEqual arguments, [ExpectedException] usage, hard casts instead of Assert.IsInstanceOfType, Single() instead of Assert.ContainsSingle.
4. Collection and string assertions — StringAssert/CollectionAssert calls that have Assert class equivalents.
5. Data-driven test modernization — IEnumerable<object[]> DynamicData sources that should use ValueTuple or TestDataRow.
6. TestContext gaps — property injection instead of constructor injection, nullable or null! declarations, missing CancellationToken forwarding.
7. Advanced feature opportunities — flaky tests without [Retry], platform-specific tests without [OSCondition], CI-only tests without [CICondition].
8. Coverage gaps — public and protected methods with no corresponding test, error paths not covered.

For each finding: file and line reference, severity (correctness / modernization / style), and a concrete fix. End with a summary table grouped by severity.
```
