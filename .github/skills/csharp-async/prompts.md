# Copilot Prompts for the `csharp-async` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/csharp-async/skill.md`

This skill is designed to review C# async code for correctness, performance, naming conventions, exception handling, cancellation, and common async pitfalls — and to suggest improvements that follow C# async best practices.

---

## dotNetDave-Ready Async Audit Prompt

This prompt should be used with a GitHub Agent. They can take a very long time to produce results.

```text
Use the csharp-async skill to perform a full async best-practices audit on [class]

Report:
1. Naming convention violations — async methods missing the Async suffix.
2. Return type issues — async void non-event-handlers, missed ValueTask<T> opportunities.
3. Exception handling gaps — swallowed exceptions, missing try/catch around awaits, fire-and-forget Task discard.
4. Blocking and deadlock risks — .Wait(), .Result, .GetAwaiter().GetResult(), sync-over-async patterns.
5. ConfigureAwait(false) gaps — every library await missing ConfigureAwait(false).
6. Cancellation token gaps — long-running async methods missing CancellationToken, tokens not forwarded.
7. Parallelization opportunities — sequential awaits on independent tasks that could use Task.WhenAll().
8. Async stream improvements — IEnumerable<T> over I/O-bound data that should be IAsyncEnumerable<T>.

For each finding: file and line reference, severity (correctness / performance / style), and a concrete fix. End with a summary table grouped by severity.
```
---

## General Async Code Review

```text
Use the csharp-async skill to review this file for async best practices. Check naming conventions, return types, exception handling, ConfigureAwait usage, blocking calls, and common async pitfalls. Report all findings with file and line references and suggest concrete fixes.
```

```text
Use the csharp-async skill to audit the current project for async anti-patterns. I want a prioritized list of issues grouped by severity: correctness issues first, then performance issues, then style issues.
```

---

## Naming Conventions

```text
Use the csharp-async skill to check that all async methods in this file follow the Async suffix naming convention. Report any methods that are missing the suffix or are named inconsistently with their synchronous counterparts.
```

```text
Use the csharp-async skill to find async methods in this project that are not named with the Async suffix and suggest corrected names.
```

---

## Return Types

```text
Use the csharp-async skill to review the return types used by async methods in this file. Flag any async void methods that are not event handlers, any missed ValueTask<T> opportunities for hot-path methods, and any Task-returning methods that could be simplified.
```

```text
Use the csharp-async skill to identify places where ValueTask<T> should be used instead of Task<T> to reduce allocations. Focus on frequently-called async methods that often complete synchronously.
```

---

## Exception Handling

```text
Use the csharp-async skill to audit exception handling in all async methods in this file. Flag swallowed exceptions, missing try/catch around await expressions, and any places where Task.FromException() should be used instead of throwing directly.
```

```text
Use the csharp-async skill to find async methods where exceptions could be silently lost. Include any fire-and-forget patterns that discard the returned Task without handling it.
```

---

## ConfigureAwait and Deadlock Prevention

```text
Use the csharp-async skill to review this library code for ConfigureAwait(false) usage. Flag every await expression that is missing ConfigureAwait(false) in non-UI, reusable library code.
```

```text
Use the csharp-async skill to check for potential deadlocks in this code. Look for .Wait(), .Result, .GetAwaiter().GetResult(), and any mixing of blocking and async code that could cause a deadlock on a synchronization context.
```

---

## Blocking Calls and Sync-Over-Async

```text
Use the csharp-async skill to find all synchronous blocking calls on Task-returning methods in this project. Report every use of .Wait(), .Result, and .GetAwaiter().GetResult() with their location and a suggested async replacement.
```

```text
Use the csharp-async skill to identify sync-over-async anti-patterns in this code. I want exact locations and a concrete async alternative for each finding.
```

---

## Cancellation Tokens

```text
Use the csharp-async skill to review this code for cancellation token support. Flag async methods that perform long-running or I/O-bound work but do not accept a CancellationToken parameter, and suggest where tokens should be threaded through.
```

```text
Use the csharp-async skill to check that CancellationToken parameters are consistently forwarded through all async call chains in this file. Flag any place where a token is accepted but not passed to downstream awaited calls.
```

---

## Parallel Execution

```text
Use the csharp-async skill to identify places in this code where multiple independent async operations are awaited sequentially but could be run in parallel with Task.WhenAll(). Report each location with a concrete before/after fix.
```

```text
Use the csharp-async skill to review this code for Task.WhenAll() and Task.WhenAny() usage. Flag any sequential await chains on independent tasks and suggest parallelization where safe.
```

---

## Async Streams

```text
Use the csharp-async skill to identify places in this code where IAsyncEnumerable<T> and async streams (await foreach) could replace synchronous IEnumerable<T> returns over I/O-bound sequences.
```

```text
Use the csharp-async skill to review async stream usage in this file. Check that IAsyncEnumerable<T> methods accept CancellationToken, use [EnumeratorCancellation], and that callers use WithCancellation() correctly.
```

---

## Async Void

```text
Use the csharp-async skill to find all async void methods in this project. For each one, determine whether it is a legitimate event handler or a bug, and suggest converting non-event-handler async void methods to async Task.
```

---

## Performance-Focused Async Review

```text
Use the csharp-async skill to review this code for async performance issues. Focus on unnecessary async/await wrapping (pass-through tasks), missing ConfigureAwait(false), ValueTask<T> opportunities, and Task allocation overhead in hot paths.
```

```text
Use the csharp-async skill to audit this high-throughput service for async overhead. Look for unnecessary state machine allocations, redundant awaits that add overhead without benefit, and opportunities to return completed tasks directly.
```

---
