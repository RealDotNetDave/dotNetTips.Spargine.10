# Copilot Prompts for the `run-tests` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/run-tests/skill.md`

This skill detects the test platform (VSTest or Microsoft.Testing.Platform) and framework (MSTest, xUnit, NUnit, TUnit), runs tests using `dotnet test`, and applies filters correctly. It covers all SDK versions (.NET 8, 9, and 10+) and the correct argument syntax for each combination.

---

## dotNetDave-Ready Run-Tests Prompt

This prompt should be used with a GitHub Agent. They can take a very long time to produce results.

```text
Use the run-tests skill to produce a complete test execution reference for this solution.

Report:
1. Detected SDK version (from dotnet --version and global.json).
2. Detected test platform — VSTest or MTP — and how it was determined.
3. Detected test framework — MSTest, xUnit, NUnit, or TUnit — and version.
4. The correct dotnet test command to run all tests with a TRX report.
5. The correct command to run tests filtered by class name.
6. The correct command to run tests filtered by method name.
7. The correct command to run tests filtered by category.
8. The correct command to run with code coverage.
9. The correct command to run with hang detection (2-minute timeout).
10. Any configuration issues found (missing packages, incorrect platform settings, multi-TFM considerations).

Use the exact syntax appropriate for the detected platform and SDK version. Flag any pitfalls specific to this project's configuration.
```
---

## Run All Tests

```text
Use the run-tests skill to run all tests in this solution. Detect whether the project uses VSTest or Microsoft.Testing.Platform, identify the SDK version, and provide the correct dotnet test command.
```

```text
Use the run-tests skill to run all tests in this project and generate a TRX results file. Detect the platform and SDK version and use the correct flag (--logger trx for VSTest, --report-trx for MTP).
```

```text
Use the run-tests skill to run all tests in this solution without rebuilding. Use --no-build and provide the correct dotnet test command for the detected platform.
```

---

## Platform and Framework Detection

```text
Use the run-tests skill to detect whether this project uses VSTest or Microsoft.Testing.Platform, and which test framework (MSTest, xUnit, NUnit, or TUnit) is in use. Check global.json, the .csproj, Directory.Build.props, and Directory.Packages.props and report what you find.
```

```text
Use the run-tests skill to determine the correct dotnet test invocation for this project. I am not sure whether it uses VSTest or MTP, or which .NET SDK version applies. Detect everything and show me the right command.
```

---

## Filtering Tests

```text
Use the run-tests skill to run only the tests in the [TypeName] class. Detect the platform and framework and use the correct filter syntax — VSTest expression syntax or the MTP framework-specific flags.
```

```text
Use the run-tests skill to run only tests in this solution that match the [TestCategory] category. Provide the correct --filter expression for the detected platform and framework.
```

```text
Use the run-tests skill to run a single test method named [MethodName]. Detect the platform, identify whether to use --filter FullyQualifiedName, --filter-method, or --treenode-filter, and provide the exact command.
```

```text
Use the run-tests skill to run only failed tests from the last run. Show me the correct filter expression for the detected platform and framework.
```

```text
Use the run-tests skill to run all tests whose names contain the word [keyword]. Provide the correct contains (~) filter expression or MTP equivalent for the detected framework.
```

---

## Multi-TFM Projects

```text
Use the run-tests skill to run tests for only the net10.0 target framework in this multi-TFM project. Provide the correct --framework flag for the detected platform and SDK version.
```

---

## Code Coverage

```text
Use the run-tests skill to run all tests in this project and collect code coverage. Detect the platform — use --collect "Code Coverage" for VSTest or --coverage for MTP — and provide the exact command.
```

---

## Blame and Hang Detection

```text
Use the run-tests skill to run tests with blame mode enabled. I suspect one of my tests is crashing the test host. Use --blame-crash and --blame-hang-timeout to detect the culprit, and provide the correct syntax for the detected platform and SDK version.
```

```text
Use the run-tests skill to run tests with a hang timeout of 2 minutes. If a test hangs longer than that, abort it. Detect the platform and provide the correct flag (--blame-hang-timeout for VSTest or MTP).
```

---

## Troubleshooting Test Discovery

```text
Use the run-tests skill to diagnose why tests are not being discovered in this project. Check for missing Microsoft.NET.Test.Sdk, incorrect platform detection, and any project configuration issues that would prevent dotnet test from finding tests.
```

```text
Use the run-tests skill to troubleshoot a DllNotFoundException or test host crash during discovery. Enable diagnostic logging (--diagnostic) and explain how to interpret the output.
```

```text
Use the run-tests skill to diagnose why my TUnit tests are not running with dotnet test. Check whether the project is configured for MTP and whether the SDK version requires using dotnet run instead.
```

---

## MTP-Specific Scenarios

```text
Use the run-tests skill to run tests in this Microsoft.Testing.Platform project on .NET SDK 9. I need to pass MTP-specific arguments. Show me the correct placement of the -- separator and provide the full command.
```

```text
Use the run-tests skill to run tests in this Microsoft.Testing.Platform project on .NET SDK 10. Show me the correct dotnet test command using --project and native MTP argument syntax without the -- separator.
```

```text
Use the run-tests skill to run this MTP test project as a standalone executable instead of using dotnet test. Show me all three alternative invocation methods: dotnet run, dotnet exec, and the direct executable path.
```

---

## xUnit v3 Filtering

```text
Use the run-tests skill to filter xUnit v3 tests on MTP. I want to run only tests in the [ClassName] class. Use the correct --filter-class syntax instead of the VSTest expression syntax.
```

```text
Use the run-tests skill to run only xUnit v3 tests with a specific trait on MTP. Use --filter-trait and provide the exact command for SDK 9 (with -- separator) and SDK 10+ (without).
```

---

## TUnit Filtering

```text
Use the run-tests skill to run a specific subset of TUnit tests using the treenode filter. My test is in namespace [Namespace], class [ClassName], method [MethodName]. Provide the correct --treenode-filter path syntax.
```
---

