// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-09-2026
// ***********************************************************************
// <copyright file="PerformanceStopwatchTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Core.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Diagnostics;

[ExcludeFromCodeCoverage]
[TestClass]
public class PerformanceStopwatchTests
{


	private readonly ILogger _logger = new NullLogger<PerformanceStopwatchTests>();

	[TestMethod]
	public void AddDiagnosticEntry_WithEmptyMessage_ThrowsArgumentException()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.AddDiagnosticEntry_WithEmptyMessage_ThrowsArgumentException));

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => psw.AddDiagnosticEntry(string.Empty));
	}

	[TestMethod]
	public void AddDiagnosticEntry_WithNullMessage_ThrowsArgumentNullException()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.AddDiagnosticEntry_WithNullMessage_ThrowsArgumentNullException));

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => psw.AddDiagnosticEntry(null));
	}

	[TestMethod]
	public void AddDiagnosticEntryTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.AddDiagnosticEntryTest));

		psw.AddDiagnosticEntry("Test diagnostic entry");

		Assert.HasCount(1, psw.Diagnostics);
		Assert.Contains("Test diagnostic entry", psw.Diagnostics[0].Message);
	}

	[TestMethod]
	public void AlertThreshold_IsSetCorrectly()
	{
		var threshold = TimeSpan.FromSeconds(5);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(threshold);

		Assert.AreEqual(threshold, psw.AlertThreshold);
	}


	[TestMethod]
	public void ClearDiagnosticsTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ClearDiagnosticsTest));

		Thread.Sleep(500);

		psw.StopReset(this._logger, "Test message 1");
		psw.StopReset(this._logger, "Test message 2");

		Assert.IsNotEmpty(psw.Diagnostics);

		psw.ClearDiagnostics();

		Assert.IsEmpty(psw.Diagnostics);
	}

	[TestMethod]
	public void ClearLapsTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ClearLapsTest));

		psw.RecordLap();
		psw.RecordLap();

		Assert.HasCount(2, psw.GetLaps());

		psw.ClearLaps();

		Assert.IsEmpty(psw.GetLaps());
	}

	[TestMethod]
	public void ConstructorWithoutTitleTest()
	{
		var psw = new PerformanceStopwatch();

		Assert.AreEqual(string.Empty, psw.Title);
	}

	[TestMethod]
	public void ConstructorWithTitleTest()
	{
		var title = "TestTitle";
		var psw = new PerformanceStopwatch(title);

		Assert.AreEqual(title, psw.Title);
	}

	[TestMethod]
	public void Diagnostics_AreSortedByTimestamp()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.Diagnostics_AreSortedByTimestamp));

		psw.AddDiagnosticEntry("First message");
		Thread.Sleep(50);
		psw.AddDiagnosticEntry("Second message");
		Thread.Sleep(50);
		psw.AddDiagnosticEntry("Third message");

		var diagnostics = psw.Diagnostics;

		Assert.HasCount(3, diagnostics);
		Assert.IsTrue(diagnostics[0].Timestamp <= diagnostics[1].Timestamp);
		Assert.IsTrue(diagnostics[1].Timestamp <= diagnostics[2].Timestamp);
	}


	[TestMethod]
	public void DiagnosticsLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(title: nameof(this.DiagnosticsLogTest));
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopRestart(this._logger, "Load users from database.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));

		Thread.Sleep(1000);

		result = psw.StopRestart(logger: this._logger, message: "Save users to database.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));

		Assert.IsNotNull(psw.Diagnostics);

		Assert.IsNotNull(psw.ToString());
	}

	[TestMethod]
	public void DiagnosticsTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.DiagnosticsTest));

		Thread.Sleep(500);

		psw.StopReset(this._logger, "Test message");

		var diagnostics = psw.Diagnostics;

		Assert.IsNotEmpty(diagnostics);
		Assert.Contains("Test message", diagnostics[0].Message);
	}

	[TestMethod]
	public void ExportToJson_ContainsTitle()
	{
		var title = "JsonExportTest";
		var psw = PerformanceStopwatch.StartNew(title);

		var json = psw.ExportToJson();

		Assert.Contains(title, json);
	}

	[TestMethod]
	public void ExportToJson_IsFormattedJson()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ExportToJson_IsFormattedJson));

		var json = psw.ExportToJson();

		Assert.Contains(Environment.NewLine, json);
		Assert.Contains("{", json);
		Assert.Contains("}", json);
	}

	[TestMethod]
	public void ExportToJsonTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ExportToJsonTest));

		Thread.Sleep(500);

		psw.RecordLap();
		psw.AddDiagnosticEntry("Test diagnostic entry");

		var json = psw.ExportToJson();

		Assert.Contains("ElapsedTimeMs", json);
		Assert.Contains("Laps", json);
		Assert.Contains("Diagnostics", json);
	}

	[TestMethod]
	public void GetDiagnosticMessagesTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.GetDiagnosticMessagesTest));

		psw.AddDiagnosticEntry("Test diagnostic message");

		var messages = psw.GetDiagnosticMessages();

		Assert.HasCount(1, messages);
		Assert.Contains("Test diagnostic message", messages[0]);
	}

	[TestMethod]
	public void GetLapsTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.GetLapsTest));

		psw.RecordLap();
		psw.RecordLap();

		var laps = psw.GetLaps();

		Assert.HasCount(2, laps);
	}

	[TestMethod]
	public void GetSummaryReport_ContainsLapInformation()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.GetSummaryReport_ContainsLapInformation));

		psw.RecordLap();

		var report = psw.GetSummaryReport();

		Assert.Contains("Lap 0", report);
	}

	[TestMethod]
	public void GetSummaryReportTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.GetSummaryReportTest));

		Thread.Sleep(500);

		psw.RecordLap();
		psw.AddDiagnosticEntry("Test diagnostic entry");

		var report = psw.GetSummaryReport();

		Assert.Contains("Performance Report", report);
		Assert.Contains("Test diagnostic entry", report);
	}

	[TestMethod]
	public void GetTotalTimeString()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.GetTotalTimeString));

		Thread.Sleep(500);

		var timeString = psw.GetTotalTimeString();

		Assert.StartsWith("Total Time:", timeString);
	}

	[TestMethod]
	public void IsThresholdExceeded_WhenThresholdExceeded_ReturnsTrue()
	{
		var alertThreshold = TimeSpan.FromMilliseconds(50);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(alertThreshold, nameof(this.IsThresholdExceeded_WhenThresholdExceeded_ReturnsTrue));

		Thread.Sleep(200);

		Assert.IsTrue(psw.IsThresholdExceeded);
	}

	[TestMethod]
	public void IsThresholdExceeded_WhenThresholdNotExceeded_ReturnsFalse()
	{
		var alertThreshold = TimeSpan.FromSeconds(10);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(alertThreshold, nameof(this.IsThresholdExceeded_WhenThresholdNotExceeded_ReturnsFalse));

		Thread.Sleep(100);

		Assert.IsFalse(psw.IsThresholdExceeded);
	}

	[TestMethod]
	public void IsThresholdExceeded_WhenThresholdNotSet_ReturnsFalse()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.IsThresholdExceeded_WhenThresholdNotSet_ReturnsFalse));

		Thread.Sleep(100);

		Assert.IsFalse(psw.IsThresholdExceeded);
	}

	[TestMethod]
	public void LogMessage_WithNullLogger_ThrowsArgumentNullException()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.LogMessage_WithNullLogger_ThrowsArgumentNullException));

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => psw.LogMessage(null, "Test message"));
	}

	[TestMethod]
	public void LogMessage_WithNullMessage_ThrowsArgumentNullException()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.LogMessage_WithNullMessage_ThrowsArgumentNullException));

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => psw.LogMessage(this._logger, null));
	}

	[TestMethod]
	public void LogMessageTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.LogMessageTest));

		Thread.Sleep(500);

		psw.LogMessage(this._logger, "Intermediate log message");

		Assert.IsNotEmpty(psw.Diagnostics);
		Assert.Contains("Intermediate log message", psw.Diagnostics[0].Message);
	}

	[TestMethod]
	public void RecordLap_MultipleLaps_AreSortedByTime()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.RecordLap_MultipleLaps_AreSortedByTime));

		Thread.Sleep(100);
		psw.RecordLap();

		Thread.Sleep(50);
		psw.RecordLap();

		Thread.Sleep(200);
		psw.RecordLap();

		var laps = psw.GetLaps();

		Assert.HasCount(3, laps);
		Assert.IsTrue(laps[0] < laps[1]);
		Assert.IsTrue(laps[1] < laps[2]);
	}

	[TestMethod]
	public void RecordLapTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.RecordLapTest));

		psw.RecordLap();

		Assert.HasCount(1, psw.GetLaps());
	}

	[TestMethod]
	public void StartNewTest()
	{
		var psw = PerformanceStopwatch.StartNew();

		Assert.IsNotNull(psw);
	}

	[TestMethod]
	public void StartNewWithAlertThresholdTest()
	{
		var alertThreshold = TimeSpan.FromMilliseconds(100);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(alertThreshold, nameof(this.StartNewWithAlertThresholdTest));

		Assert.IsNotNull(psw);
		Assert.AreEqual(alertThreshold, psw.AlertThreshold);
	}

	[TestMethod]
	public void StartNewWithEmptyTitle_DoesNotAddColon()
	{
		var psw = PerformanceStopwatch.StartNew(string.Empty);

		Assert.AreEqual(string.Empty, psw.Title);
	}

	[TestMethod]
	public void StartNewWithTitle_AddsColonToTitle()
	{
		var title = "TestOperation";
		var psw = PerformanceStopwatch.StartNew(title);

		Assert.AreEqual($"{title}:", psw.Title);
	}

	[TestMethod]
	public void StopIfThresholdExceeded_TriggersThresholdExceededEvent()
	{
		var alertThreshold = TimeSpan.FromMilliseconds(50);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(alertThreshold, nameof(this.StopIfThresholdExceeded_TriggersThresholdExceededEvent));
		var eventTriggered = false;

		psw.ThresholdExceeded += (sender, args) => eventTriggered = true;

		Thread.Sleep(200);

		_ = psw.StopIfThresholdExceeded();

		Assert.IsTrue(eventTriggered);
	}

	[TestMethod]
	public void StopIfThresholdExceeded_WhenNoThreshold_ReturnsFalse()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopIfThresholdExceeded_WhenNoThreshold_ReturnsFalse));

		Thread.Sleep(100);

		var result = psw.StopIfThresholdExceeded();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void StopIfThresholdExceeded_WhenThresholdExceeded_ReturnsTrue()
	{
		var alertThreshold = TimeSpan.FromMilliseconds(50);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(alertThreshold, nameof(this.StopIfThresholdExceeded_WhenThresholdExceeded_ReturnsTrue));

		Thread.Sleep(200);

		var result = psw.StopIfThresholdExceeded();

		Assert.IsTrue(result);
		Assert.IsFalse(psw.IsRunning);
	}

	[TestMethod]
	public void StopIfThresholdExceeded_WhenThresholdNotExceeded_ReturnsFalse()
	{
		var alertThreshold = TimeSpan.FromSeconds(10);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(alertThreshold, nameof(this.StopIfThresholdExceeded_WhenThresholdNotExceeded_ReturnsFalse));

		Thread.Sleep(100);

		var result = psw.StopIfThresholdExceeded();

		Assert.IsFalse(result);
		Assert.IsTrue(psw.IsRunning);
	}

	[TestMethod]
	public void StopReset_TriggersResetCompletedEvent()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopReset_TriggersResetCompletedEvent));
		var eventTriggered = false;

		psw.ResetCompleted += (sender, args) => eventTriggered = true;

		Thread.Sleep(100);

		_ = psw.StopReset();

		Assert.IsTrue(eventTriggered);
	}

	[TestMethod]
	public void StopReset_TriggersStoppedCompletedEvent()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopReset_TriggersStoppedCompletedEvent));
		var eventTriggered = false;
		TimeSpan? eventElapsed = null;

		psw.StopCompleted += (sender, args) =>
		{
			eventTriggered = true;
			eventElapsed = args.Elapsed;
		};

		Thread.Sleep(100);

		var elapsed = psw.StopReset();

		Assert.IsTrue(eventTriggered);
		Assert.IsNotNull(eventElapsed);
		Assert.IsGreaterThanOrEqualTo(100, eventElapsed.Value.TotalMilliseconds);
	}

	[TestMethod]
	public void StopResetLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopResetLogTest));
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopReset(this._logger, "Call to Database.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopResetTest()
	{
		var psw = PerformanceStopwatch.StartNew();
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopReset();

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopResetWithoutLoggerTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopResetWithoutLoggerTest));

		Thread.Sleep(500);

		var elapsed = psw.StopReset();

		Assert.IsGreaterThanOrEqualTo(500, elapsed.TotalMilliseconds);
		Assert.AreEqual(0, psw.ElapsedMilliseconds);
	}

	[TestMethod]
	public void StopRestart_TriggersStoppedCompletedEvent()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopRestart_TriggersStoppedCompletedEvent));
		var eventTriggered = false;

		psw.StopCompleted += (sender, args) => eventTriggered = true;

		Thread.Sleep(100);

		_ = psw.StopRestart();

		Assert.IsTrue(eventTriggered);
	}


	[TestMethod]
	public void StopRestartLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopRestartLogTest));
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopRestart(this._logger, "Call to database #2.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopRestartTest()
	{
		var psw = PerformanceStopwatch.StartNew();
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopRestart();

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopRestartWithoutLoggerTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopRestartWithoutLoggerTest));

		Thread.Sleep(500);

		var elapsed = psw.StopRestart();

		Assert.IsGreaterThanOrEqualTo(500, elapsed.TotalMilliseconds);
		Assert.IsGreaterThanOrEqualTo(0, psw.ElapsedMilliseconds);
	}

	[TestMethod]
	public void ToStringTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ToStringTest));

		Thread.Sleep(500);

		psw.StopReset(this._logger, "Test message");

		var result = psw.ToString();

		Assert.Contains("Test message", result);
	}
}
