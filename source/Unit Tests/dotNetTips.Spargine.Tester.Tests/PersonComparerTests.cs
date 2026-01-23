using System;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests
{
	[TestClass]
	public class PersonComparerTests
	{

		[TestMethod]
		public void Equals_BothNull_ReturnsTrue()
		{
			var comparer = new PersonEqualityComparer();

			Assert.IsTrue(comparer.Equals(null, null));
		}

		[TestMethod]
		public void Equals_DifferentId_ReturnsFalse()
		{
			var person1 = new Person("test1@example.com", "1234567890");
			var person2 = new Person("test2@example.com", "ABCDEFGHIJ");
			var comparer = new PersonEqualityComparer();

			Assert.IsFalse(comparer.Equals(person1, person2));
		}

		[TestMethod]
		public void Equals_OneNull_ReturnsFalse()
		{
			var person = new Person("test@example.com", "1234567890");
			var comparer = new PersonEqualityComparer();

			Assert.IsFalse(comparer.Equals(person, null));
			Assert.IsFalse(comparer.Equals(null, person));
		}

		[TestMethod]
		public void Equals_SameId_ReturnsTrue()
		{
			var person1 = new Person("test1@example.com", "1234567890");
			var person2 = new Person("test2@example.com", "1234567890");
			var comparer = new PersonEqualityComparer();

			Assert.IsTrue(comparer.Equals(person1, person2));
		}
		[TestMethod]
		public void Equals_SameReference_ReturnsTrue()
		{
			var person = new Person("test@example.com", "1234567890");
			var comparer = new PersonEqualityComparer();

			Assert.IsTrue(comparer.Equals(person, person));
		}

		[TestMethod]
		public void GetHashCode_NullPerson_ReturnsZero()
		{
			var comparer = new PersonEqualityComparer();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
			Assert.AreEqual(0, comparer.GetHashCode(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
		}

		[TestMethod]
		public void GetHashCode_SameId_ReturnsSameHash()
		{
			var person1 = new Person("test1@example.com", "1234567890");
			var person2 = new Person("test2@example.com", "1234567890");
			var comparer = new PersonEqualityComparer();

			Assert.AreEqual(comparer.GetHashCode(person1), comparer.GetHashCode(person2));
		}
	}
}
