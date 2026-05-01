# DotNetTips.Spargine.10 - 2026.10.4.23

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
* **Modified On:** 

### T GetValue(Microsoft.Win32.RegistryKey key, System.String name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** GetValue
* **Modified By:** David McCarter
* **Modified On:** 

*****
## DotNetTips.Spargine.IO.DirectoryHelper

### System.String AppDataFolder()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** AppDataFolder
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean CheckPermission(System.IO.DirectoryInfo directory, System.Security.AccessControl.FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void CopyDirectory(System.IO.DirectoryInfo source, System.IO.DirectoryInfo destination, System.Boolean overwrite)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** CopyDirectory
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.Core.SimpleResult<System.Int32> DeleteDirectory(System.IO.DirectoryInfo path, System.Byte retries, System.Boolean recursive)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** DeleteDirectory
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.Generic.IAsyncEnumerable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>> LoadFilesAsync(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> directories, System.String searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** LoadFilesAsync
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void LoadOneDriveAccounts(Microsoft.Win32.RegistryKey accountKey, System.Collections.Generic.List<DotNetTips.Spargine.IO.OneDriveFolder> folders)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** LoadOneDriveAccounts
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.IO.OneDriveFolder> LoadOneDriveFolders()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** LoadOneDriveFolders
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void LoadOneDriveFoldersFromKey(Microsoft.Win32.RegistryKey oneDriveKey, System.Collections.Generic.List<DotNetTips.Spargine.IO.OneDriveFolder> folders)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** LoadOneDriveFoldersFromKey
* **Modified On:** 

### DotNetTips.Spargine.Core.SimpleResult<System.Int32> MoveDirectory(System.IO.DirectoryInfo source, System.IO.DirectoryInfo destination, System.Byte retries)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** MoveDirectory
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.IO.OneDriveFolder ParseOneDriveFolder(Microsoft.Win32.RegistryKey key)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ParseOneDriveFolder
* **Modified On:** 

### System.Void RemoveAttributes(System.IO.DirectoryInfo path, System.IO.FileAttributes& attributesToRemove)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** RemoveAttributes
* **Modified On:** 

### System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> SafeDirectorySearch(System.IO.DirectoryInfo path, System.String searchPattern, System.IO.SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeDirectorySearch
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.IO.FileInfo> SafeFileSearch(System.IO.DirectoryInfo path, System.String searchPattern, System.IO.SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.Generic.IEnumerable<System.IO.FileInfo> SafeFileSearch(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> directories, System.String searchPattern, System.IO.SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Check Performance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean SafeHasFoldersOrFiles(System.IO.DirectoryInfo path, System.IO.SearchOption searchOption, System.Collections.ObjectModel.ReadOnlyCollection<System.String> searchPatterns)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/14/2021
* **Description:** SafeDirectorySearch
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void SetFileAttributesToNormal(System.IO.DirectoryInfo path)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SetFileAttributesToNormal
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void SetOneDriveFolderAccount(Microsoft.Win32.RegistryKey key, DotNetTips.Spargine.IO.OneDriveFolder folder, System.String displayNameKey)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SetOneDriveFolderAccount
* **Modified On:** 

### System.Void SetOneDriveFolderEmail(Microsoft.Win32.RegistryKey key, DotNetTips.Spargine.IO.OneDriveFolder folder, System.String emailKey)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SetOneDriveFolderEmail
* **Modified On:** 

*****
## DotNetTips.Spargine.IO.DriveHelper

### System.String GetDriveFormat(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetDriveFormat
* **Modified On:** 

### System.Int64 GetDriveFreeSpace(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetDriveFreeSpace
* **Modified On:** 

### System.String GetDriveLabel(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetDriveLabel
* **Modified On:** 

### System.String GetDriveSerialNumber(System.String drive)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetDriveSerialNumber
* **Documentation:** https://dotnettips.wordpress.com/2007/12/14/finding-a-drives-serial-number/
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int64 GetDriveTotalSize(System.String drive)

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/10/2023
* **Description:** GetDriveTotalSize
* **Modified By:** David McCarter
* **Modified On:** 

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
* **Modified On:** 

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
* **Modified On:** 

*****
## DotNetTips.Spargine.IO.FileHelper

### System.Void AddAttributes(System.IO.FileInfo file, System.IO.FileAttributes& attributesToAdd)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** AddAttributes
* **Modified On:** 

### System.Void AddReadOnlyAttribute(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** AddReadOnlyAttribute
* **Modified On:** 

### System.Boolean CheckPermission(System.IO.FileInfo file, System.Security.AccessControl.FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int64 CopyFile(System.IO.FileInfo file, System.IO.DirectoryInfo destination)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CopyFile
* **Modified On:** 

### System.Boolean CopyFile(System.IO.FileInfo file, System.IO.DirectoryInfo destination, DotNetTips.Spargine.IO.FileHelper.CopyProgressRoutine progressCallback)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CopyFile
* **Modified On:** 

### System.Threading.Tasks.Task<System.Int64> CopyFileAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CopyFileAsync
* **Modified On:** 

### DotNetTips.Spargine.Core.SimpleResult<System.Collections.ObjectModel.ReadOnlyCollection<System.String>> DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection<System.String> files, System.Boolean stopOnFirstError)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** DeleteFiles
* **Modified On:** 

### System.Threading.Tasks.Task DownloadFileFromWebAndUnzipAsync(System.Uri remoteUri, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** DownloadFileFromWebAndUnzipAsync
* **Modified On:** 

### System.Threading.Tasks.Task<DotNetTips.Spargine.Core.SimpleResult<System.Int32>> DownloadFileFromWebAsync(System.Uri remoteUri, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** DownloadFileFromWebAsync
* **Modified On:** 

### System.Boolean FileHasInvalidChars(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** FileHasInvalidChars
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidFileNameChars { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean MoveFile(System.IO.FileInfo file, System.IO.FileInfo destinationFile, System.Boolean replaceExisting, System.Int32 retryCount)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** MoveFile
* **Modified On:** 

### System.Void RemoveArchiveAttribute(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** RemoveArchiveAttribute
* **Modified On:** 

### System.Void RemoveAttributes(System.IO.FileInfo file, System.IO.FileAttributes& attributesToRemove)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** RemoveAttributes
* **Modified On:** 

### System.Void RemoveReadOnlyAttribute(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** RemoveReadOnlyAttribute
* **Modified On:** 

### System.Threading.Tasks.Task UnGZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** UnGZipAsync
* **Modified On:** 

### System.Threading.Tasks.Task UnGZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Boolean deleteGZipFile, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** UnGZipAsync
* **Modified On:** 

### System.Threading.Tasks.Task UnWinZipAsync(System.String zipPath, System.String expandedDirectoryPath, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **CreatedOn:** 
* **Description:** UnWinZipAsync
* **Modified On:** 

### System.Threading.Tasks.Task UnZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** UnZipAsync
* **Modified On:** 

### System.Threading.Tasks.Task UnZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Boolean deleteZipFile, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** UnZipAsync
* **Modified On:** 

*****
## DotNetTips.Spargine.IO.FileProcessor

### System.Int32 CopyFiles(System.Collections.Generic.IEnumerable<System.IO.FileInfo> files, System.IO.DirectoryInfo destination, System.Boolean& overwrite, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/20/2026
* **Description:** CopyFiles
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int32 CopyFilesWithOriginalPath(System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& files, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** CopyFilesWithOriginalPath
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int32 DeleteFiles(System.Collections.Generic.IEnumerable<System.IO.FileInfo> files, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFiles
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int32 DeleteFolders(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> folders, System.Boolean& recursive, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFolders
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int32 MoveFiles(System.Collections.Generic.IEnumerable<System.IO.FileInfo> files, System.IO.DirectoryInfo destination, System.Boolean& overwrite, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/20/2026
* **Description:** MoveFiles
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int32 MoveFilesWithOriginalPath(System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& files, System.IO.DirectoryInfo destination, System.Boolean& overwrite, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/20/2026
* **Description:** MoveFilesWithOriginalPath
* **Modified By:** David McCarter
* **Modified On:** 

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
* **Modified On:** 

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter
* **Modified On:** 

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2, System.String path3)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter
* **Modified On:** 

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2, System.String path3, System.String path4)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter
* **Modified On:** 

### System.String EnsureTrailingSlash(System.String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean HasInvalidFilterChars(System.String filter)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidFilterChars()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidPathNameChars()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean PathContainsWildcard(System.String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** PathContainsWildcard
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean PathHasInvalidChars(System.String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> PathSeparators { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter
* **Modified On:** 

*****
## DotNetTips.Spargine.IO.TempFileManager

### System.String CreateFile()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CreateFile
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> CreateFiles(System.Int32& count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CreateFiles
* **Modified On:** 

### System.Void DeleteAllFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** DeleteAllFiles
* **Modified On:** 

### System.Void DeleteFile(System.String fileName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** DeleteFile
* **Modified On:** 

### System.Void Dispose()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **CreatedOn:** 
* **Description:** Dispose
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetManagedFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetManagedFiles
* **Modified On:** 

### System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** DisposeAsync
* **Modified On:** 

*****
## DotNetTips.Spargine.Net.Http.HttpClientHelper

### System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetHttpResponseAsync(System.Uri url, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetHttpResponseAsync
* **Modified On:** 

### System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri url, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetHttpResponseAsync
* **Modified On:** 

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
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean IsProcessRunning(System.String processName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Void KillProcess(System.String processName, System.Int32 waitForExitMilliseconds, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### * **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Not Required
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** LoadService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

### System.Boolean ServiceExists(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceExists
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

### * **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceStatus
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.ServiceActionResult StartService(System.String serviceName, System.Boolean startServicesDependedOn, System.Boolean startDependingServices, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Needs Update
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void StartServices(System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& requests, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void StartStopServices(System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.ServiceAction, DotNetTips.Spargine.10, Version=2026.10.4.23, Culture=neutral, PublicKeyToken=null]]& requests, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartStopServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.ServiceActionResult StopService(System.String serviceName, System.Boolean stopServicesDependedOn, System.Boolean stopDependingServices, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Needs Update
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StopService
* **Modified By:** David McCarter
* **Modified On:** 

### System.Void StopServices(System.Collections.Generic.IEnumerable<System.String> requests, Microsoft.Extensions.Logging.ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StopServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter
* **Modified On:** 

*****
**Generated by Spargine - dotNetTips.com on 4/30/2026 9:36:47 PM UTC**
