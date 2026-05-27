# Copilot Prompts for the `coverage-analysis` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/coverage-analysis/skill.md`

This skill is designed to run project-wide code coverage collection, generate reports via ReportGenerator, calculate CRAP (Change Risk Anti-Patterns) scores per method, and surface risk hotspots — complex code with low test coverage that is dangerous to modify.

---

## David-Ready Coverage Audit Prompt

This prompt should be used with a GitHub Agent. They can take a very long time to produce results.

```text
Use the coverage-analysis skill to perform a full coverage and risk audit on [class].

Use these thresholds:
- Line coverage: 90%
- Branch coverage: 80%
- CRAP score limit: 5
- Top N hotspots: 20

Report:
1. Total methods analyzed and flagged hotspot count.
2. Risk hotspot table sorted by CRAP score descending (method, complexity, line coverage, branch coverage, CRAP score).
3. Coverage gaps by file — methods below threshold sorted by coverage ascending.
4. Methods with zero coverage.
5. Whether ReportGenerator HTML report was generated and where it is located.
6. Final coverage summary table (line %, branch %, methods meeting threshold, methods failing threshold).
7. Recommended next tests — the three methods where adding tests would most reduce overall CRAP risk.

Flag any test failures encountered during dotnet test but proceed with partial data. Note any coverage provider additions made automatically.
```
---

## General Solution-Wide Coverage Run

```text
Use the coverage-analysis skill to run a full coverage analysis on this solution. Use default thresholds (80% line, 70% branch, CRAP ≤ 5). Report total methods analyzed, flagged hotspot count, the risk hotspot table, coverage gaps by file, and the final coverage summary.
```

```text
Use the coverage-analysis skill to analyze the current solution and identify which methods are the riskiest to change. Surface the top 10 CRAP score hotspots, their complexity, coverage percentages, and recommended next tests.
```

---

## CRAP Score Focus

```text
Use the coverage-analysis skill to compute CRAP scores for every method in this solution. Flag any method with a CRAP score above 30. Show method name, cyclomatic complexity, line coverage, and CRAP score sorted descending.
```

```text
Use the coverage-analysis skill to identify the methods with the highest CRAP scores in this project. I want to understand which methods are both complex and under-tested so I can prioritize where to write tests next.
```

```text
Use the coverage-analysis skill and focus the CRAP threshold at 15 instead of the default 30. I want to surface medium-risk methods before they become high-risk.
```

---

## Coverage Gap Identification

```text
Use the coverage-analysis skill to identify coverage gaps in this solution. Show all methods below 80% line coverage grouped by file, sorted by coverage ascending, so I can address the worst gaps first.
```

```text
Use the coverage-analysis skill to find all public methods with zero coverage. I want to know which APIs have never been exercised by any test in the suite.
```

```text
Use the coverage-analysis skill to determine why my solution's coverage has plateaued. Identify the files and methods that are blocking improvement and rank them by their potential impact on overall coverage if tested.
```

---

## Refactoring Safety

```text
Use the coverage-analysis skill to assess whether this file is safe to refactor. Show CRAP scores, line coverage, and branch coverage for all methods in the file. Flag anything with CRAP > 15 as high risk.
```

```text
Use the coverage-analysis skill to evaluate the risk of refactoring the methods I am about to change. I need CRAP scores and branch coverage before I proceed.
```

---

## Custom Thresholds

```text
Use the coverage-analysis skill with a line coverage threshold of 90%, branch coverage threshold of 80%, and a CRAP threshold of 20. I want a strict audit ahead of a production release.
```

```text
Use the coverage-analysis skill with a CRAP threshold of 50 and top 20 hotspots. I am doing a quick scan and only want the most severe outliers.
```

---

## Pre-Existing Coverage Data

```text
Use the coverage-analysis skill. Skip test execution — I already have Cobertura XML at TestResults/coverage-analysis/raw/coverage.cobertura.xml. Run only ReportGenerator and the CRAP score computation, then produce the full report.
```

```text
Use the coverage-analysis skill against the existing Cobertura XML files in my TestResults directory. Do not re-run dotnet test. Generate the risk hotspot table and coverage gap analysis from the existing data.
```

---

## Release-Readiness Coverage Audit

```text
Use the coverage-analysis skill to run a release-readiness coverage audit on this solution. Use line threshold 90%, branch threshold 80%, and CRAP threshold 15. Identify every method that would fail these thresholds, group by severity, and recommend the minimum set of tests to bring the solution within acceptable bounds.
```

```text
Use the coverage-analysis skill as a release gate check. Report whether the solution meets 80% line and 70% branch coverage thresholds. Surface all methods that are blocking the gate and estimate the effort to close each gap.
```

---

## Output-Control Prompts

```text
Use the coverage-analysis skill and keep the output concise. I only want the risk hotspot table, the top coverage gaps by file, and the final summary. Skip the detailed per-method breakdown.
```

```text
Use the coverage-analysis skill and produce the full detailed report including the HTML report via ReportGenerator, the CRAP score table, coverage gaps by file, and the final summary. Save the report to TestResults/coverage-analysis/coverage-analysis.md and open it.
```
---
