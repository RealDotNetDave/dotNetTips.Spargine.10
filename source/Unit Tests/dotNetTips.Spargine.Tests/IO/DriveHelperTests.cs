// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-11-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-08-2025
// ***********************************************************************
// <copyright file="DriveHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
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
		Assert.IsTrue(result > 0); // Assuming the drive C:\ has free space
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
		Assert.IsTrue(result > 0); // Assuming the drive C:\ has a total size
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetFixedDrives()
	{
		var result = DriveHelper.GetFixedDrives();

		Assert.IsTrue(result.Count > 0);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetRemovableDrives()
	{
		var result = DriveHelper.GetRemovableDrives();

		Assert.IsNotNull(result);
	}

}
