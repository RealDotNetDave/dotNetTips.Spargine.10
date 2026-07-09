// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="FileHelperDownloadFileFromWebAsyncBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark test for FileHelper.DownloadFileFromWebAsync using a local loopback HTTP listener.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark test for <see cref="FileHelper.DownloadFileFromWebAsync(Uri, DirectoryInfo, CancellationToken)"/>.
/// Uses a local loopback <see cref="HttpListener"/> to avoid external network dependency during benchmark runs.
/// </summary>
[SuppressMessage("Reliability", "CA1001:Types that own disposable fields should be disposable", Justification = "Disposed in Cleanup() via BenchmarkDotNet lifecycle.")]
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileHelperDownloadFileFromWebAsyncBenchmark : Benchmark
{
	private static readonly byte[] _payload = CreatePayload(4096);
	private DirectoryInfo? _destinationPath;
	private Uri? _downloadUri;
	private HttpListener? _listener;

	private CancellationTokenSource? _listenerCancellationTokenSource;
	private Task? _listenerTask;

	private DirectoryInfo DestinationPath => this._destinationPath ?? throw new InvalidOperationException();

	private Uri DownloadUri => this._downloadUri ?? throw new InvalidOperationException();

	/// <summary>
	/// Overrides Cleanup to stop listener and remove benchmark artifacts.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		if (this._listenerCancellationTokenSource is not null)
		{
			this._listenerCancellationTokenSource.Cancel();
		}

		if (this._listener is not null)
		{
			this._listener.Stop();
			this._listener.Close();
			this._listener = null;
		}

		if (this._listenerTask is not null)
		{
			try
			{
				this._listenerTask.GetAwaiter().GetResult();
			}
			catch (OperationCanceledException)
			{
			}
			catch (HttpListenerException)
			{
			}
		}

		this._listenerCancellationTokenSource?.Dispose();
		this._listenerCancellationTokenSource = null;

		if (this._destinationPath is not null)
		{
			_ = DirectoryHelper.DeleteDirectory(this._destinationPath, retries: 5);
			this._destinationPath = null;
		}
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.DownloadFileFromWebAsync(Uri, DirectoryInfo, CancellationToken)"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.DownloadFileFromWebAsync))]
	[BenchmarkCategory(Categories.IO)]
	public async Task DownloadFileFromWebAsync()
	{
		var result = await FileHelper.DownloadFileFromWebAsync(this.DownloadUri, this.DestinationPath).ConfigureAwait(false);

		this.Consume(result);
	}

	/// <summary>
	/// Removes downloaded file between iterations.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		var filePath = Path.Combine(this.DestinationPath.FullName, "payload.bin");

		if (File.Exists(filePath))
		{
			File.Delete(filePath);
		}
	}

	/// <summary>
	/// Initializes loopback listener and destination directory.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._destinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperDownloadFileFromWebAsyncBenchmark) + "_download_" + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(this._destinationPath.FullName);

		var port = GetAvailablePort();
		var prefix = $"http://127.0.0.1:{port}/";
		this._downloadUri = new Uri(prefix + "payload.bin");

		this._listenerCancellationTokenSource = new CancellationTokenSource();
		this._listener = new HttpListener();
		this._listener.Prefixes.Add(prefix);
		this._listener.Start();

		this._listenerTask = Task.Run(() => ServeAsync(this._listener, this._listenerCancellationTokenSource.Token));
	}

	private static byte[] CreatePayload(int length)
	{
		var data = new byte[length];

		for (var index = 0; index < data.Length; index++)
		{
			data[index] = (byte)(index % byte.MaxValue);
		}

		return data;
	}

	private static int GetAvailablePort()
	{
		using var listener = new TcpListener(IPAddress.Loopback, 0);
		listener.Start();
		var port = ((IPEndPoint)listener.LocalEndpoint).Port;
		listener.Stop();
		return port;
	}

	private static async Task ServeAsync(HttpListener listener, CancellationToken cancellationToken)
	{
		while (!cancellationToken.IsCancellationRequested)
		{
			HttpListenerContext context;

			try
			{
				context = await listener.GetContextAsync().WaitAsync(cancellationToken).ConfigureAwait(false);
			}
			catch (OperationCanceledException)
			{
				break;
			}
			catch (HttpListenerException)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					break;
				}

				throw;
			}

			using var response = context.Response;
			response.StatusCode = (int)HttpStatusCode.OK;
			response.ContentType = "application/octet-stream";
			response.ContentLength64 = _payload.Length;

			await response.OutputStream.WriteAsync(_payload, cancellationToken).ConfigureAwait(false);
		}
	}
}
