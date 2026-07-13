---
user-invocable: false
description: Search the known-issues knowledge base (GitHub issues labeled "kb") for symptoms, root causes, and mitigations. Use when the user reports unexpected behavior that may already have a documented fix.
argument-hint: <keyword or issue number>
allowed-tools: Bash(gh issue list *), Bash(gh issue view *)
---

# Known Issues

Search the GitHub issues database for documented known issues, root causes, and mitigations.

## Instructions

The known-issues database is GitHub issues labeled `kb`. Default repo is `microsoft/skills-for-copilot-studio`.

Parse `$ARGUMENTS`:
- If empty — list all known issues
- If a number (e.g., `42`) — view that specific issue
- If a keyword or phrase — search known issues for it
- If it starts with a GitHub repo slug (`owner/repo`) followed by optional keyword — use that repo

### Command reference

**List all known issues:**
```bash
gh issue list --label kb --repo microsoft/skills-for-copilot-studio --state all --json number,title,state,body,labels,url --limit 50
```

**Search known issues by keyword:**
```bash
gh issue list --label kb --repo microsoft/skills-for-copilot-studio --state all --search "<keyword>" --json number,title,state,body,labels,url --limit 20
```

**View a specific issue by number:**
```bash
gh issue view <number> --repo microsoft/skills-for-copilot-studio --json number,title,state,body,labels,url,comments
```

Replace the repo if the user specified a different one.

### Output format

For list and search results, present a summary table:

```
| # | Title | Status |
|---|-------|--------|
| 12 | Validation fails on nested ConditionGroup | Closed |
```

For each issue that matches the user's symptom, extract and show the structured content:

```
Issue #12 — Validation fails on nested ConditionGroup [CLOSED]
URL: https://github.com/microsoft/skills-for-copilot-studio/issues/12

Symptom:     <from issue body>
Root Cause:  <from issue body>
Mitigation:  <from issue body>
Affects:     <from issue body>
```

Prefer closed issues with mitigations — they have confirmed fixes. Flag open issues as "under investigation" or "workaround available."

### After presenting results

- **Match found**: Share the issue number, link, and mitigation. Ask if the user wants to apply the workaround.
- **No match**: Tell the user no known issue matches, then continue the debugging workflow (validate YAML, check schema, etc.). Never stop here if no match is found.
