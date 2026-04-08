// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-11-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="DriveHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class DriveHelperTests
{

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFormat_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveFormat(null));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFormat_ValidDrive_ReturnsFormat()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveFormat(drive);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result)); // Assuming the drive C:\ has a format
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFreeSpace_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveFreeSpace(null));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFreeSpace_ValidDrive_ReturnsFreeSpace()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveFreeSpace(drive);

		// Assert
		Assert.IsGreaterThan(0, result); // Assuming the drive C:\ has free space
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveLabel_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveLabel(null));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveLabel_ValidDrive_ReturnsLabel()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveLabel(drive);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result)); // Assuming the drive C:\ has a label
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveSerialNumber_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveSerialNumber(null));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveSerialNumber_ValidDrive_ReturnsSerialNumber()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveSerialNumber(drive);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result)); // Assuming the drive C:\ has a serial number
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveTotalSize_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveTotalSize(null));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveTotalSize_ValidDrive_ReturnsTotalSize()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveTotalSize(drive);

		// Assert
		Assert.IsGreaterThan(0, result); // Assuming the drive C:\ has a total size
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetFixedDrives()
	{
		var result = DriveHelper.GetFixedDrives();

		Assert.IsNotEmpty(result);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetRemovableDrives()
	{
		var result = DriveHelper.GetRemovableDrives();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFormatEmptyDriveThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveFormat(string.Empty));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFreeSpaceEmptyDriveThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveFreeSpace(string.Empty));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveLabelEmptyDriveThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveLabel(string.Empty));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveSerialNumberEmptyDriveThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveSerialNumber(string.Empty));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveTotalSizeEmptyDriveThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DriveHelper.GetDriveTotalSize(string.Empty));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetFixedDrivesAllDrivesAreFixedType()
	{
		// Act
		var result = DriveHelper.GetFixedDrives();

		// Assert
		Assert.IsTrue(result.All(d => d.DriveType == DriveType.Fixed));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetFixedDrivesAllDrivesAreReady()
	{
		// Act
		var result = DriveHelper.GetFixedDrives();

		// Assert
		Assert.IsTrue(result.All(d => d.IsReady));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetFixedDrivesContainsSystemDrive()
	{
		// Arrange
		var systemDriveRoot = Path.GetPathRoot(Environment.SystemDirectory);

		// Act
		var result = DriveHelper.GetFixedDrives();

		// Assert
		Assert.IsFalse(string.IsNullOrWhiteSpace(systemDriveRoot));
		Assert.IsTrue(result.Any(d => string.Equals(d.Name, systemDriveRoot, StringComparison.OrdinalIgnoreCase)));
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetRemovableDrivesAllDrivesAreRemovableType()
	{
		// Act
		var result = DriveHelper.GetRemovableDrives();

		// Assert - if removable drives are present, they must all be Removable type
		if (result.Count > 0)
		{
			Assert.IsTrue(result.All(d => d.DriveType == DriveType.Removable));
		}
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetRemovableDrivesAllDrivesAreReady()
	{
		// Act
		var result = DriveHelper.GetRemovableDrives();

		// Assert - if removable drives are present, they must all be ready
		if (result.Count > 0)
		{
			Assert.IsTrue(result.All(d => d.IsReady));
		}
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveTotalSizeIsGreaterThanOrEqualToFreeSpace()
	{
		// Arrange
		var drive = Path.GetPathRoot(Environment.SystemDirectory);

		// Act
		var totalSize = DriveHelper.GetDriveTotalSize(drive);
		var freeSpace = DriveHelper.GetDriveFreeSpace(drive);

		// Assert
		Assert.IsGreaterThanOrEqualTo(freeSpace, totalSize);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveLabelValidDriveReturnsNotNull()
	{
		// Arrange
		var drive = Path.GetPathRoot(Environment.SystemDirectory);

		// Act
		var result = DriveHelper.GetDriveLabel(drive);

		// Assert
		Assert.IsNotNull(result);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveSerialNumberValidDriveReturnsNotNull()
	{
		// Arrange
		var drive = Path.GetPathRoot(Environment.SystemDirectory);

		// Act
		var result = DriveHelper.GetDriveSerialNumber(drive);

		// Assert
		Assert.IsNotNull(result);
	}

}
