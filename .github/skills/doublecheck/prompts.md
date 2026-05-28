# Copilot Prompts for the `doublecheck` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/doublecheck/skill.md`

This skill runs a three-layer verification pipeline on AI-generated output — extracting every verifiable claim, finding supporting or contradicting sources via web search, running an adversarial hallucination review, and producing a structured report with source links for human review. It operates in **active mode** (persistent, inline verification on every response) or **one-shot mode** (verify a specific piece of output on demand).

---

## dotNetDave-Ready Verification Prompt

```text
Use the doublecheck skill to run a full three-layer verification on the response above.

Report:
1. Self-audit — every verifiable claim extracted and categorized (Factual, Statistical, Citation, Entity, Causal, Temporal), with internal consistency check.
2. Source verification — web search results for each claim, with source URLs rated by authority (primary vs. secondary).
3. Adversarial review — hallucination pattern check (fabricated citations, unsourced statistics, plausible-but-wrong associations, temporal confusion, overgeneralizations, missing qualifiers).
4. Final claim table — each claim rated VERIFIED / PLAUSIBLE / UNVERIFIED / DISPUTED / FABRICATION RISK with source link.
5. Priority findings — any DISPUTED or FABRICATION RISK claims called out at the top before the full table.
6. Limitations disclosure — standard limitations of this verification pipeline.

Do not omit the limitations disclosure. Provide links, not verdicts — I decide what's true.
```
---

## Activating and Deactivating Persistent Mode

```text
Use the doublecheck skill to activate persistent verification mode. From now on, verify the factual claims in each of your responses and append an inline verification summary before you reply.
```

```text
Use the doublecheck skill to turn on active mode. I want to see a Verification section after every substantive response you give me in this conversation.
```

```text
Turn off doublecheck.
```

---

## One-Shot Verification of Previous Output

```text
Use the doublecheck skill to verify the response you just gave me. Run the full three-layer pipeline — self-audit, source verification, and adversarial review — and produce a complete verification report with source links.
```

```text
Use the doublecheck skill to verify the following text: [paste text here]. Extract every verifiable claim, search for supporting or contradicting sources, and produce a full verification report.
```

```text
Full report.
```

---

## Citations and References

```text
Use the doublecheck skill to verify all citations in the response above. Check that each case name, statute, standard, and paper actually exists and that the cited content says what the text claims it says. Flag anything rated FABRICATION RISK prominently.
```

```text
Use the doublecheck skill to verify the API documentation references in this response. Check that the types, method signatures, and configuration options match the current official documentation and flag anything that may be outdated.
```

```text
Use the doublecheck skill to verify all NuGet package names, versions, and API surface mentioned in this response against current official documentation.
```

---

## Statistics and Numbers

```text
Use the doublecheck skill to verify the statistics in this response. Find a primary source for each specific number or percentage. Rate any statistic with no identifiable source as FABRICATION RISK.
```

```text
Use the doublecheck skill to audit the numerical claims in the text above. Flag every precise figure that has no cited source, and search for contradicting data from authoritative sources.
```

---

## Technical and Security Content

```text
Use the doublecheck skill to verify the CVE numbers, vulnerability descriptions, and affected version ranges mentioned in this response. Confirm each CVE exists in the National Vulnerability Database and that the description matches the official advisory.
```

```text
Use the doublecheck skill to verify the security guidance in this response. Check that configuration recommendations, cryptographic algorithm choices, and threat model claims match current authoritative sources (OWASP, NIST, Microsoft Security).
```

```text
Use the doublecheck skill to verify the .NET performance recommendations in this response. Check that each claim about allocation behavior, JIT optimization, or API performance is consistent with current official .NET documentation and benchmarking guidance.
```

```text
Use the doublecheck skill to verify the C# language feature claims in this response. Confirm that syntax, semantics, and version availability match the current official C# specification and release notes.
```

---

## Legal and Regulatory Content

```text
Use the doublecheck skill to run a full verification report on this legal analysis. Apply elevated scrutiny to every case citation, statutory reference, and jurisdictional claim. Flag any citation that cannot be found in a legal database as FABRICATION RISK.
```

```text
Use the doublecheck skill to verify the regulatory claims in this response. Confirm that each requirement is attributed to the correct jurisdiction, is currently in force, and has not been superseded by recent changes.
```

---

## Medical and Scientific Content

```text
Use the doublecheck skill to verify the study citations in this response. Confirm each paper exists, the results are accurately described, and the conclusions are not overstated relative to what the study actually found.
```

```text
Use the doublecheck skill to verify the clinical guidelines mentioned in this response. Check that they reflect current recommendations and flag anything that may have been updated since the model's training cutoff.
```

---

## Adversarial Review Only

```text
Use the doublecheck skill and focus on Layer 3 adversarial review for this response. Assume the output contains errors. Check for fabricated citations, unsourced precise statistics, plausible-but-wrong associations, temporal confusion, overgeneralizations, and missing qualifiers. Report every red flag you find.
```

```text
Use the doublecheck skill to run an adversarial review on the text I am about to paste. Do not assume the output is correct — actively try to find errors, hallucinations, and overconfident claims. [paste text here]
```

---

## Requesting a Full Report After Inline Verification

```text
The inline verification flagged a FABRICATION RISK. Run a full three-layer verification report on that claim, including source search results and adversarial analysis.
```

```text
Full report on claim [C3] from the verification section above.
```

---

