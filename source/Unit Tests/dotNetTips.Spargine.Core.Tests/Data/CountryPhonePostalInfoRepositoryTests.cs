// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="CountryPhonePostalInfoRepositoryTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class CountryPhonePostalInfoRepositoryTests
{

	[TestMethod]
	public void GetCountriesTest()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo();

		Assert.IsNotNull(result);

		Assert.AreEqual(250, result.Count);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_ByCountryName_ReturnsInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("United States");

		Assert.IsNotNull(result);
		Assert.AreEqual("United States", result.Name);
	}
	[TestMethod]
	public void GetCountryPhonePostalInfo_ByIso2_ReturnsInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("US");

		Assert.IsNotNull(result);
		Assert.AreEqual("United States", result.Name);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_ByIso3_ReturnsInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("USA");

		Assert.IsNotNull(result);
		Assert.AreEqual("United States", result.Name);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_InvalidIso_ReturnsNull()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("ZZ");

		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_InvalidIso3_ReturnsNull()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("ZZZ");

		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_InvalidCountryName_ReturnsNull()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("Nonexistent Country");

		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_CaseInsensitiveIso2_ReturnsInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("us");

		Assert.IsNotNull(result);
		Assert.AreEqual("United States", result.Name);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_CaseInsensitiveIso3_ReturnsInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("usa");

		Assert.IsNotNull(result);
		Assert.AreEqual("United States", result.Name);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_CaseInsensitiveName_ReturnsInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("united states");

		Assert.IsNotNull(result);
		Assert.AreEqual("United States", result.Name);
	}

	[TestMethod]
	public void GetCountryPhonePostalInfo_SingleCharInput_ReturnsNull()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("X");

		Assert.IsNull(result);
	}

	[TestMethod]
	public void ValidatePhoneNumber_NullCountry_ReturnsFalse()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("ZZ", "1234567890");

		Assert.IsFalse(result);
	}


	[TestMethod]
	public void ValidatePhoneNumberDOInvalidCountryCodeTest()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("Dominican Republic", "900-555-666-7777", true);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberDOValidCountryCodeTest()
	{

		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber(countryNameOrIso: "Dominican Republic", phoneNumber: "1-809-555-666-7777", validateCountryCode: true);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSInvalidCountryCodeTest()
	{

		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "9-555-666-7777", true);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSInvalidTest()
	{

		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "12-34");

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSValidCountryCodeTest()
	{

		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "1-555-666-7777", true);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSValidTest()
	{

		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "555-666-7777");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePostalCode_UnknownCountry_ReturnsUnknown()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("ZZ", "12345");
		Assert.AreEqual(PostalCodeState.Unknown, result);
	}

	[TestMethod]
	public void ValidatePostalCode_WhitespacePostalCode_ReturnsInvalid()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("United States", "   ");

		Assert.AreEqual(PostalCodeState.Invalid, result);
	}

	[TestMethod]
	public void ValidatePostalCodeUSInvalidTest()
	{

		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("United States", "1234");

		Assert.AreEqual(PostalCodeState.Invalid, result);
	}

	[TestMethod]
	public void ValidatePostalCodeUSValidFullTest()
	{

		var result = CountryPhonePostalInfoRepository.ValidatePostalCode(countryNameOrIso: "United States", postalCode: "92130-1234");

		Assert.AreEqual(PostalCodeState.Valid, result);
	}

	[TestMethod]
	public void ValidatePostalCodeUSValidTest()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("United States", "92130");

		Assert.AreEqual(PostalCodeState.Valid, result);
	}

	[TestMethod]
	public void ValidatePhoneNumber_FormattedNumber_ReturnsTrue()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "(555) 666-7777");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePhoneNumber_WithIso2_ValidNumber_ReturnsTrue()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("US", "5556667777");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePhoneNumber_WithIso3_ValidNumber_ReturnsTrue()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("USA", "5556667777");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePhoneNumber_ValidCountryCode_WrongLength_ReturnsFalse()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "1-555-66", true);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePhoneNumber_EmptyPhoneNumber_ReturnsFalse()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "");

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePostalCode_EmptyPostalCode_ReturnsInvalid()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("United States", "");

		Assert.AreEqual(PostalCodeState.Invalid, result);
	}

	[TestMethod]
	public void ValidatePostalCode_NullPostalCode_ReturnsInvalid()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("United States", null);

		Assert.AreEqual(PostalCodeState.Invalid, result);
	}

	[TestMethod]
	public void ValidatePostalCode_CountryWithNoPostalRegex_ReturnsUnknown()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("Angola", "12345");

		Assert.AreEqual(PostalCodeState.Unknown, result);
	}

	[TestMethod]
	public void ValidatePostalCode_WithIso2_ValidCode_ReturnsValid()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("US", "92130");

		Assert.AreEqual(PostalCodeState.Valid, result);
	}

	[TestMethod]
	public void ValidatePostalCode_WithIso3_ValidCode_ReturnsValid()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("USA", "92130");

		Assert.AreEqual(PostalCodeState.Valid, result);
	}
}
