# Copilot Prompts for the `crap-score` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/crap-score/skill.md`

This skill calculates targeted CRAP (Change Risk Anti-Patterns) scores for .NET methods, classes, or source files. It combines cyclomatic complexity analysis with Cobertura code coverage data to identify code that is both complex and undertested, and provides actionable recommendations for reducing risk.

---

## dotNetDave-Ready CRAP Score Prompt
```text
Use the crap-score skill to analyze [ClassName] in the solution.

After computing CRAP scores:
1. Show the full results table sorted by CRAP score descending.
2. Flag any method with CRAP >= 30 as critical — these need immediate attention.
3. For methods with CRAP between 6 and 30, calculate the exact coverage percentage needed to bring them below 6.
4. For any method where complexity alone is >= 6, recommend extract-method refactoring and show which decision points to extract.
5. Check whether the [Information] attribute UnitTestStatus should be updated to UnitTestStatus.Completed once coverage targets are met.

Be direct. Prioritize the list so I know what to work on first.
```

---

## Analyzing a Single Method

```text
Use the crap-score skill to calculate the CRAP score for the method [MethodName] in [ClassName].
```

```text
What is the CRAP score for [MethodName]? I want to know how risky it is given its current test coverage.
```

```text
Calculate the CRAP score for [MethodName] in [FilePath] and tell me what coverage percentage I need to bring it below a score of 15.
```

```text
Run a CRAP score analysis on [MethodName] and tell me whether I should add more tests or refactor the method first.
```

---

## Analyzing a Class

```text
Use the crap-score skill to analyze every method in [ClassName] and rank them by CRAP score.
```

```text
Calculate CRAP scores for all methods in [ClassName] and identify which ones are the highest risk.
```

```text
Analyze [ClassName] for CRAP scores. Show me the full table sorted by score descending, then tell me the top three offenders and what to do about them.
```

```text
Give me the CRAP scores for [ClassName]. Highlight any methods I cannot fix through testing alone and must refactor to reduce complexity.
```

---

## Analyzing a File

```text
Use the crap-score skill to analyze [FilePath] and report CRAP scores for every method in the file.
```

```text
Run CRAP score analysis on [FilePath]. I want to see which methods are critical risk and which ones are quick wins.
```

```text
Analyze [FilePath] for CRAP scores and give me a prioritized list of what to fix first — focus on high complexity and low coverage.
```

---

## Prioritizing Where to Add Tests

```text
Use the crap-score skill to find the highest-CRAP methods in [ClassName] and tell me exactly which test cases to write to bring those scores down the fastest.
```

```text
Calculate CRAP scores for [FilePath] and identify the quick wins — methods where a small increase in coverage would significantly lower the score.
```

```text
I want to improve my CRAP scores in [ClassName] without rewriting anything. Which methods should I target and what coverage do I need?
```

```text
Use the crap-score skill to tell me the minimum coverage percentage needed to bring every high-CRAP method in [FileName] below a score of 15.
```

---

## Coverage Collection + CRAP Analysis Together

```text
I don't have coverage data yet. Use the crap-score skill to run tests with coverage collection for [TestProjectPath], then compute CRAP scores for [ClassName].
```

```text
Run dotnet test with coverage for [TestProjectPath], then calculate CRAP scores for all methods in [FilePath].
```

```text
Collect code coverage for the solution and then give me CRAP scores for [ClassName]. Show the coverage command you used.
```

---

## Refactor vs. Test Decision

```text
Use the crap-score skill to analyze [ClassName]. For each high-CRAP method, tell me whether it makes more sense to add tests or refactor — and explain why.
```

```text
Calculate the CRAP score for [MethodName]. If the complexity is too high to fix through testing alone, suggest how I would break it into smaller methods.
```

```text
Analyze [FilePath] for CRAP scores and flag any methods where complexity is 15 or higher. For those, give me concrete refactoring suggestions to bring the complexity down.
```

---

```
