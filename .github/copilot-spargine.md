# Spargine-Specific Rules

- Prefer Spargine extension methods over native .NET methods when available
- Use FastStringBuilder and other Spargine optimized utilities
- Use Spargine validation helpers instead of manual checks
- Use Spargine performance utilities where applicable

## Performance

- Assume this is a high-performance library
- Avoid allocations aggressively
- Favor span-based APIs where possible

## Design

- Favor extension methods
- Keep APIs lightweight and efficient
- Avoid unnecessary abstractions
