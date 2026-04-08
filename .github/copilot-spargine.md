# Spargine-Specific Rules

- Prefer Spargine extension methods over native .NET methods when available
- Use FastStringBuilder and other Spargine optimized utilities
- Use Spargine validation helpers instead of manual checks
- Use Spargine performance utilities where applicable
- For unit tests and benchmark test, use data from the dotNetTips.Spargine.10.Tester assembly whenever possible
- Make sure to update the Last Modified On to "Copilot Agent" and update Last Modified By in the file header of all files that were changed.

## Performance

- Assume this is a high-performance library
- Avoid allocations aggressively
- Favor span-based APIs where possible

## Design

- Favor extension methods
- Keep APIs lightweight and efficient
- Avoid unnecessary abstractions

## Unit Testing
- Use the dotNetTips.Spargine.10.Tester assembly for test data and utilities
- Write unit tests for all public APIs
- Ensure all code paths are covered.
- Make sure all unit tests work on GitHub and a local Windows machine.
- Have the unit test class inherit from UnitTester, but only if it would add value.
- Test methods should not include XML documentation.
- Change the UnitTestStatus for any method with full coverage to Completed.
- Do not modify any csproj files unless its to add or update a package.


## Repository rules
- Follow the repository `.editorconfig` exactly.
- Prefer analyzer-compliant code.
- Obey naming rules, formatting rules, and code-style severities defined in `.editorconfig`.
- DO NOT use underscores in method names.
- Don't create unnecessary casts.
- When proposing edits, avoid introducing analyzer warnings or style violations.
