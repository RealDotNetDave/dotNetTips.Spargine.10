// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="GlobalSuppressions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Roslynator", "RCS1171:Simplify lazy initialization.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.GetHttpClient~System.Net.Http.HttpClient")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP014:Use a single instance of HttpClient", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.GetHttpClient~System.Net.Http.HttpClient")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.DriveHelper.GetDriveSerialNumber(System.String)~System.String")]
[assembly: SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.ServiceHelper")]
[assembly: SuppressMessage("Design", "CA1028:Enum Storage should be Int32", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.IO.CopyProgressResult")]
[assembly: SuppressMessage("Design", "CA1028:Enum Storage should be Int32", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.IO.CopyFileMode")]
[assembly: SuppressMessage("Design", "CA1028:Enum Storage should be Int32", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.IO.CopyProgressCallbackReason")]
[assembly: SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder~System.String")]
[assembly: SuppressMessage("Style", "IDE0305:Simplify collection initialization", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection{System.String},System.Boolean)~DotNetTips.Spargine.Core.SimpleResult{System.Collections.ObjectModel.ReadOnlyCollection{System.String}}")]
[assembly: SuppressMessage("Async/await", "CRR0030:Redundant 'await'", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Net.Http.HttpClientHelper.GetHttpResponseAsync(System.Uri,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.TempFileManager.GenerateRandomFile~System.String")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.CopyFilesWithOriginalPath(System.Collections.Generic.IEnumerable{System.IO.FileInfo}@,System.IO.DirectoryInfo)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.DeleteFolders(System.Collections.Generic.IEnumerable{System.IO.DirectoryInfo}@,System.Boolean@)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.DeleteFiles(System.Collections.Generic.IEnumerable{System.IO.FileInfo}@)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.TempFileManager.DeleteFile(System.String)")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP001:Dispose created", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Net.Http.HttpClientHelper.GetHttpResponseAsync(System.Uri,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP003:Dispose previous before re-assigning", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Net.Http.HttpClientHelper.GetHttpResponseAsync(System.Uri,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP003:Dispose previous before re-assigning", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Net.Http.HttpClientHelper.GetStreamAsync(System.Uri,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.IO.Stream}")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP001:Dispose created", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Net.Http.HttpClientHelper.GetStreamAsync(System.Uri,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.IO.Stream}")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP003:Dispose previous before re-assigning", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FilePropertyWriter.SetPropStringInternal(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Performance", "CA1873:Avoid potentially expensive logging", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.ServiceHelper.KillProcess(System.String,System.Int32,Microsoft.Extensions.Logging.ILogger)")]
[assembly: SuppressMessage("Performance", "CA1873:Avoid potentially expensive logging", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.ServiceHelper.StartService(System.String,System.Boolean,System.Boolean,Microsoft.Extensions.Logging.ILogger)~DotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Performance", "CA1873:Avoid potentially expensive logging", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.ServiceHelper.StartDependentServices(System.ServiceProcess.ServiceController[]@,Microsoft.Extensions.Logging.ILogger@)")]
[assembly: SuppressMessage("Performance", "CA1873:Avoid potentially expensive logging", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.ServiceHelper.StopDependentServices(System.ServiceProcess.ServiceController[],Microsoft.Extensions.Logging.ILogger)")]
[assembly: SuppressMessage("Performance", "CA1873:Avoid potentially expensive logging", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.ServiceHelper.StopService(System.String,System.Boolean,System.Boolean,Microsoft.Extensions.Logging.ILogger)~DotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Win32.RegistryHive")]
