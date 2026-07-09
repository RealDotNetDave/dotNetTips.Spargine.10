# FastStringBuilder — Developer Guide

This short guide documents the most useful FastStringBuilder APIs, sample usage patterns, and recommended benchmark tests.

## Key APIs

- FastStringBuilder.Combine(bool addLineFeed, params ReadOnlySpan<string> args)
- FastStringBuilder.CombineWithSpace(params ReadOnlySpan<string> args)
- FastStringBuilder.Concat(string delimiter, bool addLineFeed, params ReadOnlySpan<string> args)
- FastStringBuilder.Join(IEnumerable<string> values, char delimiter)
- FastStringBuilder.PerformAction(Action<StringBuilder> action)

## Examples

Combine words with spaces:

var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

Use PerformAction to write custom logic with preallocated capacity:

var result = FastStringBuilder.PerformAction(1024, sb => { sb.Append("Hello"); sb.Append(' '); sb.Append("World"); });

## Benchmark guidance

- Use the FastStringBuilderSpanBenchmark in the benchmark project as a baseline for span-based workloads.
- For micro-benchmarks, prefer 8–32 items of realistic length to expose allocation differences.
