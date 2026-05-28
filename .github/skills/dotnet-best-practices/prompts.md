# Copilot Prompts for the `dotnet-best-practices` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/dotnet-best-practices/skill.md`

This skill ensures .NET/C# code meets the best practices specific to this solution — covering XML documentation, architecture and design patterns, dependency injection, resource management, async/await, testing standards, configuration, Semantic Kernel integration, error handling, logging, performance, security, and general code quality.

---


## dotNetDave-Ready Best-Practices Audit Prompt

```text
Use the dotnet-best-practices skill to perform a full best-practices audit on [class].
Report:
1. Documentation gaps — public members missing XML doc tags, or docs that no longer match the current signature.
2. Architecture issues — SOLID violations, missing Factory or Command Handler patterns, interface naming.
3. DI problems — missing null checks, wrong service lifetime, services not backed by interfaces.
4. Async issues — blocking calls, missing ConfigureAwait(false), async void, unhandled async exceptions.
5. Resource strings — hard-coded user-facing text that should use ResourceManager.
6. Error handling and logging — swallowed exceptions, missing context in logs, generic exception types.
7. Configuration — hard-coded settings that should use IConfiguration, missing validation attributes.
8. Performance and security — disposal violations, missing input validation, optimization opportunities.
9. Testing gaps — missing failure-path tests, missing null parameter tests, incorrect assertion patterns.

For each finding: category, location (file and method), explanation, and a concrete fix. End with a prioritized summary table grouped by category.
```
---

## General Best-Practices Review

```text
Use the dotnet-best-practices skill to review this file and report every best-practice violation. Group findings by category (Documentation, Architecture, DI, Async, Testing, etc.), include specific locations, and provide a concrete fix for each issue.
```

```text
Use the dotnet-best-practices skill to perform a full best-practices audit on this project. I want a prioritized list of issues — violations that affect correctness or reliability first, then maintainability, then style.
```

---

## XML Documentation

```text
Use the dotnet-best-practices skill to audit XML documentation in this file. Find every public class, interface, method, and property that is missing a <summary>, <param>, <returns>, or <exception> tag, and generate the missing documentation.
```

```text
Use the dotnet-best-practices skill to review XML documentation completeness for all public APIs in this project. Flag any member where the documentation does not match the current signature (renamed parameters, changed return types, added exceptions).
```

---

## Architecture and Design Patterns

```text
Use the dotnet-best-practices skill to review the architecture of this file. Check that dependency injection uses primary constructor syntax, that complex object creation follows the Factory pattern, and that interfaces use the 'I' prefix naming convention.
```

```text
Use the dotnet-best-practices skill to check whether the Command Handler pattern is applied correctly in this project. Verify that handlers inherit from the correct generic base class (CommandHandler<TOptions>) and are registered with the right DI lifetime.
```

```text
Use the dotnet-best-practices skill to review SOLID principles compliance in this file. Flag any God classes, methods that do more than one thing, and interfaces that are too broad and should be segregated.
```

---

## Dependency Injection and Services

```text
Use the dotnet-best-practices skill to review dependency injection usage in this project. Verify that constructor injection is used consistently, that null checks use ArgumentNullException, and that service lifetimes (Singleton, Scoped, Transient) are appropriate for each registration.
```

```text
Use the dotnet-best-practices skill to check that all services in this project implement interfaces for testability and are registered using Microsoft.Extensions.DependencyInjection patterns.
```

---

## Resource Management and Localization

```text
Use the dotnet-best-practices skill to audit resource string usage in this file. Find any hard-coded user-facing strings that should be moved to a ResourceManager resource file, and verify that existing resource access uses the correct _resourceManager.GetString("MessageKey") pattern.
```

```text
Use the dotnet-best-practices skill to check that error messages and log messages are properly separated into distinct resource files (ErrorMessages, LogMessages) and accessed consistently.
```

---

## Async/Await

```text
Use the dotnet-best-practices skill to review async/await usage in this file. Verify that all I/O operations are async, that methods return Task or Task<T> (not void), that ConfigureAwait(false) is used where appropriate, and that async exceptions are properly handled.
```

```text
Use the dotnet-best-practices skill to find any blocking calls (.Result, .Wait(), .GetAwaiter().GetResult()) in this project that should be replaced with proper async/await patterns.
```

---

## Error Handling and Logging

```text
Use the dotnet-best-practices skill to review error handling and logging in this file. Check that structured logging uses Microsoft.Extensions.Logging, that scoped logging includes meaningful context, that specific exception types are thrown with descriptive messages, and that try-catch blocks are used only for expected failure scenarios.
```

```text
Use the dotnet-best-practices skill to find any places in this code where exceptions are swallowed, logging lacks context, or generic Exception types are thrown instead of specific ones.
```

---

## Configuration and Settings

```text
Use the dotnet-best-practices skill to review configuration handling in this project. Verify that settings use strongly-typed classes with data annotations (Required, NotEmptyOrWhitespace), that IConfiguration binding is used correctly, and that appsettings.json is the configuration source.
```

---

## Semantic Kernel and AI Integration

```text
Use the dotnet-best-practices skill to review Semantic Kernel usage in this file. Check that kernel configuration and service registration follow the established patterns, that AI model settings (ChatCompletion, Embedding) are handled correctly, and that structured output patterns are used for reliable AI responses.
```

```text
Use the dotnet-best-practices skill to audit AI/ML operations in this project for secure coding practices — input validation, sanitization, and proper handling of model outputs before they are used downstream.
```

---

## Performance and Security

```text
Use the dotnet-best-practices skill to review this file for performance and security issues. Check for missing input validation, unsanitized inputs, non-parameterized queries, and any C# 12+ or .NET 8+ optimization opportunities that have not been applied.
```

```text
Use the dotnet-best-practices skill to find any disposal pattern violations in this project — classes that hold IDisposable resources but do not implement IDisposable, and using statements that are missing where they should be applied.
```

---

## Testing Standards

```text
Use the dotnet-best-practices skill to review the test code for this project. Verify that MSTest is used with FluentAssertions, that tests follow the AAA pattern, that Moq is used for mocking, and that both success and failure scenarios are covered including null parameter validation tests.
```

---

## New File or Feature Review

```text
Use the dotnet-best-practices skill to review this new file before I submit it. Check every category — documentation, architecture, DI, async, resource strings, error handling, logging, performance, and security — and give me a checklist of anything that needs to be addressed before merging.
```

```text
Use the dotnet-best-practices skill to do a pre-merge review of this feature branch. Focus on anything that deviates from the established patterns in the rest of the codebase — naming conventions, DI registration style, async patterns, and documentation completeness.
```

---

