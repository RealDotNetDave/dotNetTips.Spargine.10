# Copilot Prompts for the `analyzing-dotnet-performance` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/analyzing-dotnet-performance/skill.md`

This skill is designed to scan C#/.NET code for performance anti-patterns across async code, memory usage, strings, collections, LINQ, regex, serialization, I/O, and related structural concerns.

---

## General Repository Scan

```text
Use the analyzing-dotnet-performance skill to scan this repository for .NET performance anti-patterns. Use standard scan depth. Report the scan execution checklist, exact hit counts, prioritized findings, concrete fixes, positive patterns, and the final severity summary table.
```

```text
Use the analyzing-dotnet-performance skill to review the current workspace before release. Treat this as a production-readiness performance audit for .NET 10. Focus on allocation-heavy patterns, string handling, LINQ usage, regex usage, collections, serialization, I/O, and structural issues like unsealed classes.
```

---

## Hot-Path Review

```text
Use the analyzing-dotnet-performance skill to review this file as hot-path code. Elevate applicable findings to their maximum severity. Focus on allocations, LINQ, string operations, regex, collections, async overhead, and repeated per-call object creation.
```

```text
Use the analyzing-dotnet-performance skill to analyze the selected method as performance-critical code. Report only findings that are likely to matter in a hot path, include exact line locations, and suggest concrete code changes.
```

---

## Critical-Only Scan

```text
Use the analyzing-dotnet-performance skill with scan depth set to critical-only. Look for deadlocks, crashes, security-sensitive issues, and patterns that could cause major performance regressions. Do not report minor micro-optimizations.
```

```text
Use the analyzing-dotnet-performance skill in critical-only mode on this project. I only want must-fix performance issues before release.
```

---

## Comprehensive Scan

```text
Use the analyzing-dotnet-performance skill with comprehensive scan depth. Check all pattern categories, even if the initial code signals are weak. Include exact counts for every recipe, including zero-hit checks.
```

```text
Run a comprehensive analyzing-dotnet-performance scan on this folder. I want a full performance anti-pattern audit, including strings, memory, collections, LINQ, regex, async, serialization, I/O, and structural patterns.
```

---

## Allocation-Heavy Code

```text
Use the analyzing-dotnet-performance skill to find avoidable allocations in this code. Pay special attention to string.Substring, ToLower/ToUpper, chained Replace calls, params arrays, LINQ, per-call List/Dictionary creation, regex allocation, and compound allocation chains.
```

```text
Use the analyzing-dotnet-performance skill to analyze this class for hidden allocation costs. Include compound allocation findings across method calls, branches, string interpolation, string.Format, regex, LINQ, and repeated object creation.
```

---

## Strings and Culture-Sensitive Operations

```text
Use the analyzing-dotnet-performance skill to review this code for string performance issues. Find missing StringComparison usage, culture-sensitive comparisons, ToLower/ToUpper allocations, Substring allocations, chained Replace calls, and string concatenation in loops.
```

```text
Use the analyzing-dotnet-performance skill to scan this file for string APIs that should use StringComparison.Ordinal or OrdinalIgnoreCase. Report exact locations and one-line fixes.
```

---

## LINQ and Collections

```text
Use the analyzing-dotnet-performance skill to review LINQ usage in this file. Assume this code may run in a hot path. Flag LINQ chains that allocate or enumerate repeatedly, but do not make blanket anti-LINQ recommendations.
```

```text
Use the analyzing-dotnet-performance skill to review collection usage. Look for per-call List or Dictionary allocations, static readonly Dictionary instances that may be FrozenDictionary candidates, unnecessary ToList calls, and repeated enumeration.
```

---

## Regex Review

```text
Use the analyzing-dotnet-performance skill to review regex usage in this project. Find per-call Regex construction, RegexOptions.Compiled usage, dynamic patterns, and places where GeneratedRegex would be appropriate.
```

```text
Use the analyzing-dotnet-performance skill to analyze this regex-heavy code. Recommend GeneratedRegex only when the pattern is a compile-time literal, and call out any places where RegexOptions.Compiled is overused.
```

---

## Serialization and I/O

```text
Use the analyzing-dotnet-performance skill to review serialization and I/O performance in this code. Focus on JsonSerializer usage, Stream/FileStream usage, HttpClient-related patterns, unnecessary buffering, and allocation-heavy data processing.
```

```text
Use the analyzing-dotnet-performance skill to audit this file for I/O and serialization bottlenecks. Include concrete fixes and note any version-specific .NET requirements.
```

---

## Cross-File Consistency

```text
Use the analyzing-dotnet-performance skill to perform a cross-file consistency check. If one file uses an optimized pattern, check sibling files in the same folder or similar classes for unoptimized equivalents and flag inconsistencies.
```

---

## Output-Control Prompts

```text
Use the analyzing-dotnet-performance skill, but keep the output compact. Group findings by severity, include exact counts, file:line locations, one-line impact statements, one-line fixes, positive findings, and the summary table. Do not include large code blocks unless the transformation is non-obvious.
```

```text
Use the analyzing-dotnet-performance skill and include the required disclaimer. I want exact hit counts, not estimates. Include zero-hit checks because they confirm good patterns.
```

---

## David-Ready Performance Audit Prompt

```text
Use the analyzing-dotnet-performance skill to perform a standard performance audit on this .NET 10 code. Treat any benchmark, serialization, collection-processing, regex, string-processing, or file I/O code as hot-path unless clearly proven otherwise. 

Report:
1. The scan execution checklist with exact hit counts, including zero-hit checks.
2. Critical findings first.
3. Moderate findings that matter on hot paths.
4. Info findings only when useful.
5. Positive performance patterns already used.
6. Concrete one-line fixes with file:line locations.
7. A final severity summary table.

Avoid generic micro-optimization advice. Verify recommendations against modern .NET behavior and call out anything that should be benchmarked before changing.
```

---

## Release-Readiness Prompt

```text
Use the analyzing-dotnet-performance skill to review this project as part of a release-readiness pass. Prioritize findings that could affect production performance, memory allocation, startup time, throughput, or scalability. Include only actionable recommendations, and clearly separate must-fix items from nice-to-have improvements.
```

---

## Benchmark-Focused Prompt

```text
Use the analyzing-dotnet-performance skill to review this benchmark code and the code under test. Look for benchmark design issues, hidden allocations, repeated setup work inside measured paths, LINQ overhead, collection allocation patterns, string allocation patterns, and anything that could distort BenchmarkDotNet results.
```

---

## Spargine-Style Prompt

```text
Use the analyzing-dotnet-performance skill to review this Spargine code with a performance-first mindset. Focus on reusable library code, public APIs, hot-path helpers, allocation reduction, modern .NET APIs, and consistency with high-performance patterns used elsewhere in the codebase. Include exact file and line references, severity, impact, and recommended fixes.
```
