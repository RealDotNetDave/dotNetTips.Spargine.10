# DotNetTips.Spargine.10 - 2026.10.7.2

## DotNetTips.Spargine.Extensions.RegistryExtensions

### Microsoft.Win32.RegistryKey GetSubKey(Microsoft.Win32.RegistryKey key, System.String& name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** GetSubKey
* **Modified By:** David McCarter

### T GetValue(Microsoft.Win32.RegistryKey key, System.String name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** GetValue
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.DirectoryHelper

### System.String AppDataFolder()

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** AppDataFolder
* **Modified By:** David McCarter

### System.Boolean CheckPermission(System.IO.DirectoryInfo directory, System.Security.AccessControl.FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Modified By:** David McCarter

### System.Void CopyDirectory(System.IO.DirectoryInfo source, System.IO.DirectoryInfo destination, System.Boolean overwrite, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** CopyDirectory
* **Modified By:** David McCarter

### DotNetTips.Spargine.Core.SimpleResult<System.Int32> DeleteDirectory(System.IO.DirectoryInfo path, System.Byte retries, System.Boolean recursive, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** DeleteDirectory
* **Modified By:** David McCarter

### System.Collections.Generic.IAsyncEnumerable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>> LoadFilesAsync(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> directories, System.String searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** LoadFilesAsync
* **Modified By:** David McCarter

### System.Void LoadOneDriveAccounts(Microsoft.Win32.RegistryKey accountKey, System.Collections.Generic.List<DotNetTips.Spargine.IO.OneDriveFolder> folders)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** LoadOneDriveAccounts

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.IO.OneDriveFolder> LoadOneDriveFolders()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** LoadOneDriveFolders
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.IO.OneDriveFolder> LoadOneDriveFoldersFromKey(Microsoft.Win32.RegistryKey oneDriveKey)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** LoadOneDriveFoldersFromKey

### DotNetTips.Spargine.Core.SimpleResult<System.Int32> MoveDirectory(System.IO.DirectoryInfo source, System.IO.DirectoryInfo destination, System.Byte retries, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** MoveDirectory
* **Modified By:** David McCarter

### DotNetTips.Spargine.IO.OneDriveFolder ParseOneDriveFolder(Microsoft.Win32.RegistryKey key)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** ParseOneDriveFolder

### System.Void RemoveAttributes(System.IO.DirectoryInfo path, System.IO.FileAttributes& attributesToRemove)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** RemoveAttributes

### System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> SafeDirectorySearch(System.IO.DirectoryInfo path, System.String searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeDirectorySearch
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.IO.FileInfo> SafeFileSearch(System.IO.DirectoryInfo path, System.String searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Modified By:** David McCarter

### System.Collections.Generic.IEnumerable<System.IO.FileInfo> SafeFileSearch(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> directories, System.String searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Modified By:** David McCarter

### System.Boolean SafeHasFoldersOrFiles(System.IO.DirectoryInfo path, System.IO.SearchOption searchOption, System.Collections.ObjectModel.ReadOnlyCollection<System.String> searchPatterns)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/14/2021
* **Description:** SafeDirectorySearch
* **Modified By:** David McCarter

### System.Void SetFileAttributesToNormal(System.IO.DirectoryInfo path, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SetFileAttributesToNormal
* **Modified By:** David McCarter

### System.Void SetOneDriveFolderAccount(Microsoft.Win32.RegistryKey key, DotNetTips.Spargine.IO.OneDriveFolder folder, System.String displayNameKey)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SetOneDriveFolderAccount

### System.Void SetOneDriveFolderEmail(Microsoft.Win32.RegistryKey key, DotNetTips.Spargine.IO.OneDriveFolder folder, System.String emailKey)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SetOneDriveFolderEmail

*****
## DotNetTips.Spargine.IO.DriveHelper

### System.String GetDriveFormat(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetDriveFormat

### System.Int64 GetDriveFreeSpace(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetDriveFreeSpace

### System.String GetDriveLabel(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetDriveLabel

### System.String GetDriveSerialNumber(System.String drive)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetDriveSerialNumber
* **Modified By:** David McCarter

### System.Int64 GetDriveTotalSize(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/10/2023
* **Description:** GetDriveTotalSize
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> GetFixedDrives()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetFixedDrives
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> GetRemovableDrives()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetRemovableDrives
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.FileHelper

### System.Void AddAttributes(System.IO.FileInfo file, System.IO.FileAttributes& attributesToAdd)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** AddAttributes

### System.Void AddReadOnlyAttribute(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** AddReadOnlyAttribute

### System.Int64 CalculateTotalFileSize(System.ReadOnlySpan<System.IO.FileInfo> files)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/9/2026
* **Description:** CalculateTotalFileSize
* **Modified By:** David McCarter

### System.Boolean CheckPermission(System.IO.FileInfo file, System.Security.AccessControl.FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Modified By:** David McCarter

### System.Int64 CopyFile(System.IO.FileInfo file, System.IO.DirectoryInfo destination)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** CopyFile

### System.Boolean CopyFile(System.IO.FileInfo file, System.IO.DirectoryInfo destination, DotNetTips.Spargine.IO.FileHelper.CopyProgressRoutine progressCallback)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** CopyFile

### System.Threading.Tasks.Task<System.Int64> CopyFileAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** CopyFileAsync

### DotNetTips.Spargine.Core.SimpleResult<System.Collections.ObjectModel.ReadOnlyCollection<System.String>> DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection<System.String> files, System.Boolean stopOnFirstError)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** DeleteFiles

### System.Threading.Tasks.Task DownloadFileFromWebAndUnzipAsync(System.Uri remoteUri, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** DownloadFileFromWebAndUnzipAsync

### System.Threading.Tasks.Task<DotNetTips.Spargine.Core.SimpleResult<System.Int32>> DownloadFileFromWebAsync(System.Uri remoteUri, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Description:** DownloadFileFromWebAsync

### System.Boolean FileHasInvalidChars(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** FileHasInvalidChars
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidFileNameChars { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Boolean MoveFile(System.IO.FileInfo file, System.IO.FileInfo destinationFile, System.Boolean replaceExisting, System.Int32 retryCount)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** MoveFile

### System.Void RemoveArchiveAttribute(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** RemoveArchiveAttribute

### System.Void RemoveAttributes(System.IO.FileInfo file, System.IO.FileAttributes& attributesToRemove)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** RemoveAttributes

### System.Void RemoveReadOnlyAttribute(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** RemoveReadOnlyAttribute

### System.Threading.Tasks.Task UnGZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** UnGZipAsync

### System.Threading.Tasks.Task UnGZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Boolean deleteGZipFile, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** UnGZipAsync

### System.Threading.Tasks.Task UnWinZipAsync(System.String zipPath, System.String expandedDirectoryPath, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** UnWinZipAsync

### System.Threading.Tasks.Task UnZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** UnZipAsync

### System.Threading.Tasks.Task UnZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Boolean deleteZipFile, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** UnZipAsync

*****
## DotNetTips.Spargine.IO.FileProcessor

### System.Int32 CopyFiles(System.Collections.Generic.IEnumerable<System.IO.FileInfo> files, System.IO.DirectoryInfo destination, System.Boolean& overwrite, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/20/2026
* **Description:** CopyFiles
* **Modified By:** David McCarter

### System.Int32 CopyFilesWithOriginalPath(System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& files, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** CopyFilesWithOriginalPath
* **Modified By:** David McCarter

### System.Int32 DeleteFiles(System.Collections.Generic.IEnumerable<System.IO.FileInfo> files, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFiles
* **Modified By:** David McCarter

### System.Int32 DeleteFolders(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> folders, System.Boolean& recursive, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFolders
* **Modified By:** David McCarter

### System.Int32 MoveFiles(System.Collections.Generic.IEnumerable<System.IO.FileInfo> files, System.IO.DirectoryInfo destination, System.Boolean& overwrite, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/20/2026
* **Description:** MoveFiles
* **Modified By:** David McCarter

### System.Int32 MoveFilesWithOriginalPath(System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& files, System.IO.DirectoryInfo destination, System.Boolean& overwrite, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/20/2026
* **Description:** MoveFilesWithOriginalPath
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.PathHelper

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String[] paths)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2, System.String path3)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2, System.String path3, System.String path4)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.IO.DirectoryInfo EnsureDirectoryCreated(System.IO.DirectoryInfo di, System.Boolean create)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** EnsureDirectoryCreated
* **Modified By:** David McCarter

### System.String EnsureTrailingSlash(System.String path)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Boolean HasInvalidFilterChars(System.String filter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidFilterChars()

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidPathNameChars()

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Boolean PathContainsWildcard(System.String path)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** PathContainsWildcard
* **Modified By:** David McCarter

### System.Boolean PathHasInvalidChars(System.String path)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> PathSeparators { get; set; }

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.TempFileManager

### System.String CreateFile()

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** CreateFile

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> CreateFiles(System.Int32& count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** CreateFiles

### System.Void DeleteAllFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** DeleteAllFiles

### System.Void DeleteFile(System.String fileName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** DeleteFile

### System.Void Dispose()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** Dispose

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetManagedFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetManagedFiles

### System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** DisposeAsync

*****
## DotNetTips.Spargine.Net.Http.HttpClientHelper

### System.Net.Http.HttpClient CreateOptimizedHttpClient(DotNetTips.Spargine.Net.Http.HttpClientOptions options)

* **Status:** New
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** CreateOptimizedHttpClient

### System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetHttpResponseAsync(System.Uri url, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetHttpResponseAsync

### System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri url, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetHttpResponseAsync

*****
## DotNetTips.Spargine.Net.Http.HttpClientOptions

*****
## DotNetTips.Spargine.Net.Sockets.SocketsHelper

*****
## DotNetTips.Spargine.ServiceHelper

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> AllServices()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** AllServices
* **Modified By:** David McCarter

### System.Boolean IsProcessRunning(System.String processName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Void KillProcess(System.String processName, System.Int32 waitForExitMilliseconds, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.ServiceProcess.ServiceController LoadService(System.String serviceName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** LoadService
* **Modified By:** David McCarter

### System.Boolean ServiceExists(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceExists
* **Modified By:** David McCarter

### System.ServiceProcess.ServiceControllerStatus ServiceStatus(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceStatus
* **Modified By:** David McCarter

### DotNetTips.Spargine.ServiceActionResult StartService(System.String serviceName, System.Boolean startServicesDependedOn, System.Boolean startDependingServices, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartService
* **Modified By:** David McCarter

### System.Void StartServices(System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& requests, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartServices
* **Modified By:** David McCarter

### System.Void StartStopServices(System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.ServiceAction, DotNetTips.Spargine.10, Version=2026.10.7.2, Culture=neutral, PublicKeyToken=null]]& requests, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartStopServices
* **Modified By:** David McCarter

### DotNetTips.Spargine.ServiceActionResult StopService(System.String serviceName, System.Boolean stopServicesDependedOn, System.Boolean stopDependingServices, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StopService
* **Modified By:** David McCarter

### System.Void StopServices(System.Collections.Generic.IEnumerable<System.String> requests, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StopServices
* **Modified By:** David McCarter

*****
**Generated by Spargine - dotNetTips.com on 7/8/2026 3:40:31 PM UTC**
