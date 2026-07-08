// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="StreamExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <c>Stream</c> providing pooled async I/O helpers and flush-and-close operations.
// </summary>
// ***********************************************************************
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <c>Stream</c> covering pooled async I/O and flush-and-close operations.
/// </summary>
[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available)]
public static class StreamExtensions
{
	private const int DefaultCopyBufferSize = 81920;

	/// <summary>
	/// Copies all bytes from <paramref name="source"/> to <paramref name="destination"/> asynchronously using a pooled buffer.
	/// </summary>
	/// <param name="source">The source stream to read from.</param>
	/// <param name="destination">The destination stream to write to.</param>
	/// <param name="cancellationToken">A cancellation token used to cancel the copy operation.</param>
	/// <returns>The total number of bytes copied.</returns>
	[Information(nameof(CopyToAsyncPooled), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static Task<long> CopyToAsyncPooled([DisallowNull] this Stream source, [DisallowNull] Stream destination, CancellationToken cancellationToken = default)
	{
		return source.CopyToAsyncPooled(destination, DefaultCopyBufferSize, cancellationToken);
	}

	/// <summary>
	/// Copies all bytes from <paramref name="source"/> to <paramref name="destination"/> asynchronously using a rented <see cref="ArrayPool{T}"/> buffer.
	/// </summary>
	/// <param name="source">The source stream to read from.</param>
	/// <param name="destination">The destination stream to write to.</param>
	/// <param name="bufferSize">The pooled buffer size to use for the transfer.</param>
	/// <param name="cancellationToken">A cancellation token used to cancel the copy operation.</param>
	/// <returns>The total number of bytes copied.</returns>
	[Information(nameof(CopyToAsyncPooled), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static async Task<long> CopyToAsyncPooled([DisallowNull] this Stream source, [DisallowNull] Stream destination, int bufferSize, CancellationToken cancellationToken = default)
	{
		source = source.ArgumentNotNull();
		destination = destination.ArgumentNotNull();

		if (bufferSize <= 0)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(bufferSize));
		}

		var buffer = ArrayPool<byte>.Shared.Rent(bufferSize);
		var totalBytesCopied = 0L;

		try
		{
			while (true)
			{
				var bytesRead = await source.ReadAsync(buffer.AsMemory(0, bufferSize), cancellationToken).ConfigureAwait(false);

				if (bytesRead == 0)
				{
					break;
				}

				await destination.WriteAsync(buffer.AsMemory(0, bytesRead), cancellationToken).ConfigureAwait(false);
				totalBytesCopied += bytesRead;
			}

			return totalBytesCopied;
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buffer);
		}
	}

	/// <summary>
	/// Flushes and closes the specified <c>Stream</c>.
	/// If <paramref name="stream"/> is <c>null</c>, the method returns without action.
	/// </summary>
	/// <param name="stream">The <c>Stream</c> to flush and close.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FlushClose), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void FlushClose([AllowNull] this Stream stream)
	{
		if (stream is not null)
		{
			stream.Flush();
			stream.Close();
		}
	}

	/// <summary>
	/// Reads exactly <paramref name="buffer"/>.Length bytes from <paramref name="stream"/>.
	/// </summary>
	/// <param name="stream">The source stream to read from.</param>
	/// <param name="buffer">The destination buffer to fill.</param>
	/// <param name="cancellationToken">A cancellation token used to cancel the read operation.</param>
	/// <returns>The total number of bytes read, which equals <paramref name="buffer"/> length when successful.</returns>
	/// <exception cref="EndOfStreamException">Thrown when the stream ends before the buffer is filled.</exception>
	[Information(nameof(ReadExactlyAsync), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static async Task<int> ReadExactlyAsync([DisallowNull] this Stream stream, Memory<byte> buffer, CancellationToken cancellationToken = default)
	{
		stream = stream.ArgumentNotNull();

		if (buffer.IsEmpty)
		{
			return 0;
		}

		var totalBytesRead = 0;

		while (totalBytesRead < buffer.Length)
		{
			var bytesRead = await stream.ReadAsync(buffer[totalBytesRead..], cancellationToken).ConfigureAwait(false);

			if (bytesRead == 0)
			{
				throw new EndOfStreamException();
			}

			totalBytesRead += bytesRead;
		}

		return totalBytesRead;
	}

	/// <summary>
	/// Writes all bytes from <paramref name="buffer"/> to <paramref name="stream"/> asynchronously.
	/// </summary>
	/// <param name="stream">The destination stream to write to.</param>
	/// <param name="buffer">The source buffer to write.</param>
	/// <param name="cancellationToken">A cancellation token used to cancel the write operation.</param>
	/// <returns>The total number of bytes written.</returns>
	[Information(nameof(WriteAllAsync), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static async Task<int> WriteAllAsync([DisallowNull] this Stream stream, ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default)
	{
		stream = stream.ArgumentNotNull();

		if (buffer.IsEmpty)
		{
			return 0;
		}

		await stream.WriteAsync(buffer, cancellationToken).ConfigureAwait(false);

		return buffer.Length;
	}
}
