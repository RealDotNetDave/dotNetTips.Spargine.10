# DotNetTips.Spargine.Benchmarking v2026.10.10.1 for .NET 10
<!-- Last Modified By: Copilot Agent; Last Modified On: 09-08-2026 -->
![Spargine 10](SPARGINE-10-BANNER-BACKGROUND-100.png)
Open-source .NET assembly from dotNetTips.com and David (dotNetDave) McCarter for benchmarking code using BenchmarkDotNet. 
This repository is for the dotNetTips.Spargine code for .NET 10. Please support this project by [**clicking here**]("https://github.com/sponsors/RealDotNetDave).
[**Click here**](https://dotnettips.wordpress.com/spargine/) to visit the Spargine page on **dotNetTips.com**. Much of this code is also documented on
[**dotNetTips.com**](https://dotnettips.wordpress.com/category/open-source/spargine/).

# NuGet
All of the Spargine assemblies listed below can be found on NuGet by
[**clicking here**](https://www.nuget.org/profiles/davidmccarter)

* **Benchmark**: Abstract base class featuring common benchmarking methods, supplemented with default attributes.
* **BenchmarkHelper**: BenchmarkHelper provides utility methods to run BenchmarkDotNet benchmarks with minimal boilerplate.
* **CollectionBenchmark**: Base class for tests utilizing collections, with additional functionality to preload collections for enhanced benchmark test speed.
* **CounterBenchmark**: Abstract class designed for benchmark tests that involve a counter.
* **LargeCollectionBenchmark**: Class for performing benchmark tests on large collections with count values set to 64, 128, 256, 512, 1024, 2048, 4096, and 8192.
* **SmallCollectionBenchmark**: Class for conducting benchmark tests on small collections with count values set to 16, 32, 64, 128, 256, 512, 1024, and 2048.
* **TinyCollectionBenchmark**: Class for performing benchmark tests on very small collections with count values set to 2, 4, 8, 16, 32, 64, 128, and 256.
## Benchmark fixture helpers

- `DataSeed` defaults to `null`. Set it during setup to reproduce byte/string fixtures with the same arguments on the same runtime, independently of helper call order. It applies to `GetByteArray`, `GetByteArrayByLength`, `GetStringArray`, and the copy helpers, not person or other scalar fixtures. Seeded data is not suitable for cryptographic use, and runtime upgrades may change the generated sequence.
- `GetByteArrayByLength(byteCount)` accepts an exact nonnegative byte count, including zero. The existing `GetByteArray(count)` continues to require at least one **byte**; older KB documentation was incorrect.
- `CopyByteArrayTo(destination)` and `CopyStringArrayTo(destination, wordMinLength, wordMaxLength)` fill the entire destination span from a private, pristine fixture. Changing an array returned by a getter does not contaminate that fixture. Empty destination spans are supported. String bounds are normalized in the same way as `GetStringArray`; the maximum is inclusive.
- Cached getters return the same mutable array for repeated equivalent requests. Private byte snapshots double retained byte-array storage; string snapshots add an array of references but do not duplicate string contents.
- `ClearDataCaches()` releases the cached source and working arrays without forcing GC or changing the seed. Existing array references remain valid. Changing `DataSeed` also clears these caches; assigning the same seed does not.

Generate fixtures during setup and save them in fields. Restore mutable working buffers outside measured code unless copying itself is the intended workload. Cache clearing and seed changes are setup/cleanup operations, not concurrent reconfiguration APIs. No automatic iteration hooks are installed by the base class; benchmarks that mutate state must explicitly choose appropriate reset boundaries.

## Asynchronous lifecycle and streams

BenchmarkDotNet now calls `GlobalSetupAsync()` and `GlobalCleanupAsync()`. Their default hooks call the synchronous `Setup()` and `Cleanup()` exactly once, preserving existing overrides.

- For synchronous initialization, continue overriding `Setup()` and call `base.Setup()` first.
- For asynchronous initialization, override `SetupAsync()`, await `base.SetupAsync()`, and then await custom initialization. Do not also call `Setup()` or add another `[GlobalSetup]` method.
- For asynchronous cleanup, override `CleanupAsync()` and await `base.CleanupAsync()`. The default now calls `Cleanup()`; overrides that previously called both base async cleanup and synchronous cleanup must remove the duplicate call.
- Manual `GlobalSetup()` and `GlobalCleanup()` entry points remain synchronous and do not run async overrides. Manual callers that need async behavior must await the corresponding async entry points.
- `ConsumeAsyncEnumerableAsync(source, cancellationToken)` consumes every element and awaits enumerator disposal. It forwards cancellation to the source and checks between elements. A pending move still requires the source to cooperate with cancellation. Enumeration and consumption are measured when this helper is called inside a benchmark.

## Temporary directories

`CreateTemporaryDirectory()` creates a unique directory only when explicitly called. The instance tracks its original path, and both global cleanup entry points recursively delete tracked directories and their contents after the cleanup hook. Cleanup is attempted even when the hook fails; already-deleted directories are accepted, and other deletion errors propagate. Failed paths remain tracked for a later cleanup attempt.

Use these directories only for disposable benchmark data. Do not move them or place data that must survive cleanup inside them. No arbitrary external path can be registered for deletion. Manually created benchmark instances must invoke a global cleanup entry point; calling only `Cleanup()` or `CleanupAsync()` does not perform tracked-directory cleanup.

## Unit tests

The standalone `Source/Unit Tests/DotNetTips.Spargine.10.Benchmarking.Tests` MSTest project contains fixture, lifecycle, async-stream, and directory-ownership regression tests. Its library reference is supplied by a project-local `Directory.Build.targets`, leaving the project file unchanged. Run it with `dotnet test` using the project path; it is not included in the open benchmarking solution.

# Benchmark Tests
[**click here**](https://github.com/RealDotNetDave/dotNetTips.Spargine.8/tree/master/docs/Benchmark%20Results)
 to view current benchmark results for this project.
# Your Support Is Appreciated!
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it! **I might just send you some cool geeky swag that includes one of my books (as supplies last).** You can also support this via 
[**GitHub Sponsors:**](https://github.com/sponsors/RealDotNetDave)
