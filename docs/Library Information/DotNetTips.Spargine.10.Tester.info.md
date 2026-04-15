# DotNetTips.Spargine.10.Tester - 2026.10.4.1

## DotNetTips.Spargine.Tester.Data.Converters.DateOnlyConverter

### System.DateOnly Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** None
* **CreatedOn:** 
* **Description:** Read
* **Modified On:** 

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.DateOnly value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** None
* **CreatedOn:** 
* **Description:** Write
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Data.Converters.IsoDateTimeOffsetConverter

### System.DateTimeOffset Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **CreatedOn:** 
* **Description:** Read
* **Modified On:** 

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.DateTimeOffset value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **CreatedOn:** 
* **Description:** Write
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Data.Converters.RegionConverter

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, DotNetTips.Spargine.Tester.Data.Region value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **CreatedOn:** 
* **Description:** Write
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Data.Converters.TimeOnlyConverter

### System.TimeOnly Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** None
* **CreatedOn:** 
* **Description:** Read
* **Modified On:** 

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.TimeOnly value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** None
* **CreatedOn:** 
* **Description:** Write
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Data.CountryRepository

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country> GetCountries()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/24/2023
* **Description:** GetCountries
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.Tester.Data.Models.Country GetCountry(DotNetTips.Spargine.Tester.Data.CountryName countryName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/14/2023
* **Description:** GetCountry
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.Tester.Data.Models.Country GetCountry(System.String countryNameOrIso)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/1/2025
* **Description:** GetCountry
* **Documentation:** https://bit.ly/SpargineTester
* **Modified By:** David McCarter
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Extensions.PersonExtensions

*****
## DotNetTips.Spargine.Tester.Extensions.PersonExtensions.<G>$8CE121D0C326519C166F2930EF8E0D92<$T0, $T1>

### System.TimeSpan Age { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** get_Age
* **Modified On:** 

### System.String FullName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** get_FullName
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.Common.ICoordinate

*****
## DotNetTips.Spargine.Tester.Models.Common.IPerson<TSelf, TAddress>

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Address

### System.String Address1 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Address1
* **Modified On:** 

### System.String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Address2
* **Modified On:** 

### System.String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** City
* **Modified On:** 

### System.String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Country
* **Modified On:** 

### System.String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CountyProvince
* **Modified On:** 

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Id
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Address op_Implicit(DotNetTips.Spargine.Tester.Models.ValueTypes.Address& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** op_Implicit
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Address op_Implicit(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** op_Implicit
* **Modified On:** 

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Phone
* **Modified On:** 

### System.String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PostalCode
* **Modified On:** 

### System.String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** State
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Address ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToAddress
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord

### DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord (System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** AddressRecord
* **Modified On:** 

### System.String Address1 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Address1
* **Modified On:** 

### System.String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Address2
* **Modified On:** 

### System.String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** City
* **Modified On:** 

### System.Int32 CompareTo(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CompareTo
* **Modified On:** 

### System.String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Country
* **Modified On:** 

### System.String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CountyProvince
* **Modified On:** 

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Id
* **Modified On:** 

### System.Boolean op_GreaterThan(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_GreaterThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_LessThan(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_LessThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Phone
* **Modified On:** 

### System.String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PostalCode
* **Modified On:** 

### System.String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** State
* **Modified On:** 

### System.Int32 System.IComparable.CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CompareTo
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToAddress
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord ToAddress(DotNetTips.Spargine.Tester.Models.ValueTypes.Address& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToAddress
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonComparerByIdThenLastName

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonComparerByLastName

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonComparerByLastNameThenFirstName

### System.Int32 Compare(DotNetTips.Spargine.Tester.Models.RefTypes.Person x, DotNetTips.Spargine.Tester.Models.RefTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Compare
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparerByEmail

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.Person x, DotNetTips.Spargine.Tester.Models.RefTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonRecordEqualityComparerByEmail

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord x, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate

### System.Int32 CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CompareTo
* **Modified On:** 

### System.Int32 CompareTo(DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CompareTo
* **Modified On:** 

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

### System.Boolean Equals(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

### System.Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetHashCode
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

### System.Int32 X { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** X
* **Modified On:** 

### System.Int32 Y { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Y
* **Modified On:** 

### System.Int32 Z { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Z
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Person

### DotNetTips.Spargine.Tester.Models.RefTypes.Person (System.String email, System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** IPerson
* **Modified On:** 

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Address> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Addresses
* **Modified On:** 

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Address> AddressesSerialization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** AddressesSerialization
* **Modified On:** 

### System.Nullable<System.DateTimeOffset> BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** BornOn
* **Modified On:** 

### System.String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CellPhone
* **Modified On:** 

### System.String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Email
* **Modified On:** 

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** FirstName
* **Modified On:** 

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Id
* **Modified On:** 

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** LastName
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Person op_Implicit(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** op_Implicit
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Person op_Implicit(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** op_Implicit
* **Modified On:** 

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Phone
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToPerson
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToPerson
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord (System.String email, System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PersonRecord
* **Modified On:** 

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Addresses
* **Modified On:** 

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> AddressesSerialization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** AddressesSerialization
* **Modified On:** 

### System.Nullable<System.DateTimeOffset> BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** BornOn
* **Modified On:** 

### System.String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CellPhone
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord Create(System.String id, System.String email, System.String firstName, System.String lastName, System.Nullable<System.DateTimeOffset> bornOn, System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> addresses, System.String cellPhone, System.String phone)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Create
* **Modified On:** 

### System.String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Email
* **Modified On:** 

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** FirstName
* **Modified On:** 

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Id
* **Modified On:** 

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** LastName
* **Modified On:** 

### System.Boolean op_GreaterThan(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_GreaterThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord op_Implicit(DotNetTips.Spargine.Tester.Models.RefTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** op_Implicit
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord op_Implicit(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** op_Implicit
* **Modified On:** 

### System.Boolean op_LessThan(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_LessThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Phone
* **Modified On:** 

### System.Int32 System.IComparable.CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CompareTo
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToPersonRecord
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ToPersonRecord(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToPersonRecord
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts.PersonRecordJsonSerializerContext

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts.PersonRefJsonSerializerContext

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Address

### DotNetTips.Spargine.Tester.Models.ValueTypes.Address (System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Address
* **Modified On:** 

### System.String Address1 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Address1
* **Modified On:** 

### System.String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Address2
* **Modified On:** 

### System.String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** City
* **Modified On:** 

### System.String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Country
* **Modified On:** 

### System.String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CountyProvince
* **Modified On:** 

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Id
* **Modified On:** 

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Phone
* **Modified On:** 

### System.String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PostalCode
* **Modified On:** 

### System.String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** State
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.ValueTypes.Address ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToAddress
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonComparerByIdThenLastName

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonComparerByLastName

### System.Int32 Compare(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Compare
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonComparerByLastNameThenFirstName

### System.Int32 Compare(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Compare
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonEqualityComparer

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonEqualityComparerByEmail

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate

### System.Int32 CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CompareTo
* **Modified On:** 

### System.Int32 CompareTo(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CompareTo
* **Modified On:** 

### System.Boolean Equals(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Equals
* **Modified On:** 

### System.Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetHashCode
* **Modified On:** 

### System.Boolean op_Equality(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord1, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_GreaterThan(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_GreaterThanOrEqual(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_Inequality(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord1, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_LessThan(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.Boolean op_LessThanOrEqual(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Modified By:** UNKNOWN
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

### System.Int32 X { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** X
* **Modified On:** 

### System.Int32 Y { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Y
* **Modified On:** 

### System.Int32 Z { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Z
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Person

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person (System.String email, System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Person
* **Modified On:** 

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Addresses
* **Modified On:** 

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> AddressesSerialization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** AddressesSerialization
* **Modified On:** 

### System.Nullable<System.DateTimeOffset> BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** BornOn
* **Modified On:** 

### System.String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CellPhone
* **Modified On:** 

### System.String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Email
* **Modified On:** 

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** FirstName
* **Modified On:** 

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Id
* **Modified On:** 

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** LastName
* **Modified On:** 

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** Phone
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToPerson
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.RefTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToPerson
* **Modified On:** 

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** ToString
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.SerializerContexts.PersonValJsonSerializerContext

*****
## DotNetTips.Spargine.Tester.PersonData

### DotNetTips.Spargine.Tester.PersonData (System.DateTimeOffset bornOn, System.String cellPhone, DotNetTips.Spargine.Tester.Data.Models.Country country, System.String email, System.String firstName, System.String lastName, System.String phone)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PersonData
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.PersonName

### DotNetTips.Spargine.Tester.PersonName ()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PersonName
* **Modified On:** 

### DotNetTips.Spargine.Tester.PersonName (System.String firstName, System.String lastName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PersonName
* **Modified On:** 

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** FirstName
* **Modified On:** 

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** LastName
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator

### System.String GetCreditCardNumber()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetCreditCardNumber
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetCreditCardNumbers(System.Int32 count)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GetCreditCardNumbers
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.RandomData

### T GenerateAddress(DotNetTips.Spargine.Tester.Data.Models.Country country, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/4/2025
* **Description:** GenerateAddress
* **Modified By:** David McCarter
* **Modified On:** 

### T GenerateAddressCollection(System.Int32& count, System.Int32& addressLength, System.Int32& countyProvinceLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 6/1/2025
* **Description:** GenerateAddressCollection
* **Modified By:** David McCarter
* **Modified On:** 

### T GenerateAddressCollection(DotNetTips.Spargine.Tester.Data.Models.Country country, System.Int32 count, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/4/2023
* **Description:** GenerateAddressCollection
* **Modified By:** David McCarter
* **Modified On:** 

### System.Byte[] GenerateByteArray(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateByteArray
* **Modified By:** David McCarter
* **Modified On:** 

### System.Char GenerateCharacter()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCharacter
* **Modified By:** David McCarter
* **Modified On:** 

### System.Char GenerateCharacter(System.Char minValue, System.Char maxValue)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCharacter
* **Modified By:** David McCarter
* **Modified On:** 

### T GenerateCoordinate()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCoordinate
* **Modified By:** David McCarter
* **Modified On:** 

### T GenerateCoordinateCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCoordinateCollection
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateCreditCard()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/13/2023
* **Description:** GenerateCreditCard
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GenerateCreditCards(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/13/2023
* **Description:** GenerateCreditCard
* **Modified By:** David McCarter
* **Modified On:** 

### System.Decimal GenerateDecimal(System.Decimal& minValue, System.Decimal& maxValue, System.Int32 decimalPlaces)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateDecimal
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateDomainExtension()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateDomainExtension
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateEmailAddress()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateEmailAddress
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateFile(System.String fileName, System.Int32 fileLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFile
* **Modified By:** David McCarter
* **Modified On:** 

### System.ValueTuple<System.String, System.Collections.ObjectModel.ReadOnlyCollection<System.String>> GenerateFiles(System.Int32 count, System.Int32 fileLength, System.String fileExtension)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFiles
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GenerateFiles(System.String path, System.Int32 count, System.Int32 fileLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFiles
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateFirstName()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/11/2023
* **Description:** GenerateFirstName
* **Modified By:** David McCarter
* **Modified On:** 

### System.Int32 GenerateInteger(System.Int32& min, System.Int32 max)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateInteger
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateKey()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateKey
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateLastName()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/11/2023
* **Description:** GenerateLastName
* **Modified By:** David McCarter
* **Modified On:** 

### System.Byte[] GenerateNonZeroByteArray(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/21/2025
* **Description:** GenerateByteArray
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateNumber(System.Int32 length)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateNumber
* **Modified By:** David McCarter
* **Modified On:** 

### T GeneratePerson(System.Int32& addressCount, System.Int32& addressLength, System.Int32& countyProvinceLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/4/2025
* **Description:** GeneratePerson
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.PersonName> GeneratePersonNames(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/15/2023
* **Description:** GeneratePersonNames
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord GeneratePersonRecord(System.Int32 addressCount, System.Int32& addressLength, System.Int32& countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GeneratePersonRecord
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> GeneratePersonRecordCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRecordCollection
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.RefTypes.Person GeneratePersonRef(System.Int32 addressCount, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRef
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person> GeneratePersonRefCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRefCollection
* **Modified By:** David McCarter
* **Modified On:** 

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person GeneratePersonVal(System.Int32 addressCount, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonVal
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> GeneratePersonValCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonValCollection
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.Models.Country country, System.Boolean includeCountryCode)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePhoneNumber
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName countryName, System.Boolean includeCountryCode)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePhoneNumber
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateRandomFileName(System.Int32 fileNameLength, System.String extension)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRandomFileName
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateRandomFileName(System.String path, System.Int32 fileNameLength, System.String extension)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRandomFileName
* **Modified By:** David McCarter
* **Modified On:** 

### System.ValueTuple<DotNetTips.Spargine.Tester.Data.Models.Country, DotNetTips.Spargine.Tester.Data.Models.State, DotNetTips.Spargine.Tester.Data.Models.City> GenerateRandomLocationData()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GenerateRandomLocationData
* **Modified On:** 

### DotNetTips.Spargine.Tester.PersonData GenerateRandomPersonData()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GenerateRandomPersonData
* **Modified On:** 

### System.ValueTuple<System.String, System.String> GenerateRandomPersonName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** GenerateRandomLocationData
* **Modified On:** 

### System.String GenerateRelativeUrl()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRelativeUrl
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateTempFile(System.Int32 fileLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Check Performance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateTempFile
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateUrl()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrl
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateUrlFragment()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlFragment
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateUrlHostName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostName
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateUrlHostNameNoProtocol()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostNameNoProtocol
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateUrlHostNameNoSubDomain()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostNameNoSubDomain
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateWord(System.Int32 length)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Check Performance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateWord(System.Int32 minLength, System.Int32 maxLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Check Performance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateWord(System.Int32 length, System.Char minCharacter, System.Char maxCharacter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter
* **Modified On:** 

### System.String GenerateWord(System.Int32 minLength, System.Int32 maxLength, System.Char minCharacter, System.Char maxCharacter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter
* **Modified On:** 

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GenerateWords(System.Int32 count, System.Int32 minLength, System.Int32 maxLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWords
* **Modified By:** David McCarter
* **Modified On:** 

### System.String LongTestString { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Not Required
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWords
* **Modified By:** David McCarter
* **Modified On:** 

*****
## DotNetTips.Spargine.Tester.UnitTester

### System.Int32 CleanupOutputDirectory(System.String searchPattern)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** CleanupOutputDirectory
* **Modified On:** 

### System.TimeSpan MeasureAction(System.Action action, System.Boolean printResult, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** MeasureAction
* **Modified On:** 

### System.Threading.Tasks.Task<System.TimeSpan> MeasureActionAsync(System.Func<System.Threading.Tasks.Task> asyncAction, System.Boolean printResult, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** MeasureActionAsync
* **Modified On:** 

### System.String OutputDirectory { get; set; }

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** OutputDirectory
* **Modified On:** 

### System.Void PrintToDebug(System.String input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PrintToDebug
* **Modified On:** 

### System.Void PrintToDebug(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PrintToDebug
* **Modified On:** 

### System.Void PrintToDebug(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** PrintToDebug
* **Modified On:** 

### System.String SaveAsJsonToFile(T input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveAsJsonToFile
* **Modified On:** 

### System.String SaveToFile(System.String input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFile
* **Modified On:** 

### System.String SaveToFile(System.String input, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFile
* **Modified On:** 

### System.String SaveToFile(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFile
* **Modified On:** 

### System.String SaveToFile(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFile
* **Modified On:** 

### System.String SaveToFile(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFile
* **Modified On:** 

### System.String SaveToFile(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFile
* **Modified On:** 

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(System.String input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFileAsync
* **Modified On:** 

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFileAsync
* **Modified On:** 

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFileAsync
* **Modified On:** 

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **CreatedOn:** 
* **Description:** SaveToFileAsync
* **Modified On:** 

*****
**Generated by Spargine - dotNetTips.com on 4/15/2026 8:14:32 PM UTC**
