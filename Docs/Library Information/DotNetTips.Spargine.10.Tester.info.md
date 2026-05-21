# DotNetTips.Spargine.10.Tester - 2026.10.5.21

## DotNetTips.Spargine.Tester.Data.Converters.DateOnlyConverter

### System.DateOnly Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** Read

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.DateOnly value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** Write

*****
## DotNetTips.Spargine.Tester.Data.Converters.IsoDateTimeOffsetConverter

### System.DateTimeOffset Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** Read

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.DateTimeOffset value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** Write

*****
## DotNetTips.Spargine.Tester.Data.Converters.RegionConverter

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, DotNetTips.Spargine.Tester.Data.Region value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** Write

*****
## DotNetTips.Spargine.Tester.Data.Converters.TimeOnlyConverter

### System.TimeOnly Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** Read

### System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.TimeOnly value, System.Text.Json.JsonSerializerOptions options)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** Write

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

### DotNetTips.Spargine.Tester.Data.Models.Country GetCountry(DotNetTips.Spargine.Tester.Data.CountryName countryName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/14/2023
* **Description:** GetCountry
* **Modified By:** David McCarter

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

*****
## DotNetTips.Spargine.Tester.Extensions.PersonExtensions

*****
## DotNetTips.Spargine.Tester.Extensions.PersonExtensions.<G>$8CE121D0C326519C166F2930EF8E0D92<$T0, $T1>

### System.TimeSpan Age { get; set; }

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** get_Age

### System.String FullName { get; set; }

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** get_FullName

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
* **Description:** Address1

### System.String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Address2

### System.String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** City

### System.String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Country

### System.String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CountyProvince

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Id

### DotNetTips.Spargine.Tester.Models.RefTypes.Address op_Implicit(DotNetTips.Spargine.Tester.Models.ValueTypes.Address& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** op_Implicit

### DotNetTips.Spargine.Tester.Models.RefTypes.Address op_Implicit(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** op_Implicit

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Phone

### System.String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** PostalCode

### System.String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** State

### DotNetTips.Spargine.Tester.Models.RefTypes.Address ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToAddress

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord

### DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord (System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** AddressRecord

### System.String Address1 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Address1

### System.String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Address2

### System.String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** City

### System.Int32 CompareTo(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CompareTo

### System.String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Country

### System.String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CountyProvince

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Equals

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Id

### System.Boolean op_GreaterThan(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_GreaterThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_LessThan(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_LessThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Phone

### System.String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** PostalCode

### System.String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** State

### System.Int32 System.IComparable.CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CompareTo

### DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToAddress

### DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord ToAddress(DotNetTips.Spargine.Tester.Models.ValueTypes.Address& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToAddress

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

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
* **Description:** Compare

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparerByEmail

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.Person x, DotNetTips.Spargine.Tester.Models.RefTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** Equals

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonRecordEqualityComparerByEmail

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord x, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** Equals

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate

### System.Int32 CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CompareTo

### System.Int32 CompareTo(DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CompareTo

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Equals

### System.Boolean Equals(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Equals

### System.Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** GetHashCode

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

### System.Int32 X { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** X

### System.Int32 Y { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Y

### System.Int32 Z { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Z

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.Person

### DotNetTips.Spargine.Tester.Models.RefTypes.Person (System.String email, System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** IPerson

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Address> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Addresses

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Address> AddressesSerialization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** AddressesSerialization

### System.Nullable<System.DateTimeOffset> BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** BornOn

### System.String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CellPhone

### System.String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Email

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** FirstName

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Id

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** LastName

### DotNetTips.Spargine.Tester.Models.RefTypes.Person op_Implicit(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** op_Implicit

### DotNetTips.Spargine.Tester.Models.RefTypes.Person op_Implicit(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** op_Implicit

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Phone

### DotNetTips.Spargine.Tester.Models.RefTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToPerson

### DotNetTips.Spargine.Tester.Models.RefTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToPerson

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

*****
## DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord (System.String email, System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** PersonRecord

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Addresses

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> AddressesSerialization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** AddressesSerialization

### System.Nullable<System.DateTimeOffset> BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** BornOn

### System.String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CellPhone

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord Create(System.String id, System.String email, System.String firstName, System.String lastName, System.Nullable<System.DateTimeOffset> bornOn, System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> addresses, System.String cellPhone, System.String phone)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** Create

### System.String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Email

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** FirstName

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Id

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** LastName

### System.Boolean op_GreaterThan(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_GreaterThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord op_Implicit(DotNetTips.Spargine.Tester.Models.RefTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** op_Implicit

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord op_Implicit(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** op_Implicit

### System.Boolean op_LessThan(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_LessThanOrEqual(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& left, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Phone

### System.Int32 System.IComparable.CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CompareTo

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToPersonRecord

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ToPersonRecord(DotNetTips.Spargine.Tester.Models.ValueTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToPersonRecord

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

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
* **Description:** Address

### System.String Address1 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Address1

### System.String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Address2

### System.String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** City

### System.String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Country

### System.String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CountyProvince

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Id

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Phone

### System.String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** PostalCode

### System.String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** State

### DotNetTips.Spargine.Tester.Models.ValueTypes.Address ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord& address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToAddress

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonComparerByIdThenLastName

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonComparerByLastName

### System.Int32 Compare(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** Compare

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonComparerByLastNameThenFirstName

### System.Int32 Compare(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** Compare

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonEqualityComparer

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** Equals

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers.PersonEqualityComparerByEmail

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.ValueTypes.Person x, DotNetTips.Spargine.Tester.Models.ValueTypes.Person y)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** Equals

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate

### System.Int32 CompareTo(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CompareTo

### System.Int32 CompareTo(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CompareTo

### System.Boolean Equals(System.Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Equals

### System.Boolean Equals(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Equals

### System.Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** GetHashCode

### System.Boolean op_Equality(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord1, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_GreaterThan(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_GreaterThanOrEqual(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_Inequality(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord1, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_LessThan(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.Boolean op_LessThanOrEqual(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate left, DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Modified By:** UNKNOWN

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

### System.Int32 X { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** X

### System.Int32 Y { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Y

### System.Int32 Z { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Z

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.Person

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person (System.String email, System.String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Person

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Addresses

### System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> AddressesSerialization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** AddressesSerialization

### System.Nullable<System.DateTimeOffset> BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** BornOn

### System.String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** CellPhone

### System.String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Email

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** FirstName

### System.String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Id

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** LastName

### System.String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** Phone

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** ToPerson

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person ToPerson(DotNetTips.Spargine.Tester.Models.RefTypes.Person& person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** ToPerson

### System.String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** ToString

*****
## DotNetTips.Spargine.Tester.Models.ValueTypes.SerializerContexts.PersonValJsonSerializerContext

*****
## DotNetTips.Spargine.Tester.PersonData

### DotNetTips.Spargine.Tester.PersonData (System.DateTimeOffset bornOn, System.String cellPhone, DotNetTips.Spargine.Tester.Data.Models.Country country, System.String email, System.String firstName, System.String lastName, System.String phone)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** PersonData

*****
## DotNetTips.Spargine.Tester.PersonName

### DotNetTips.Spargine.Tester.PersonName ()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** PersonName

### DotNetTips.Spargine.Tester.PersonName (System.String firstName, System.String lastName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** PersonName

### System.String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** FirstName

### System.String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Description:** LastName

*****
## DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator

### System.String GetCreditCardNumber()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetCreditCardNumber

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetCreditCardNumbers(System.Int32 count)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetCreditCardNumbers

*****
## DotNetTips.Spargine.Tester.RandomData

### System.Void AppendPostalCodeFormatChar(System.Text.StringBuilder sb, System.Char character)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** AppendPostalCodeFormatChar

### System.Void ApplyCityReplacement(System.Text.StringBuilder sb, System.String format, DotNetTips.Spargine.Tester.Data.Models.City city)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** ApplyCityReplacement

### DotNetTips.Spargine.Tester.RandomData.AddressComponents BuildAddressComponents(DotNetTips.Spargine.Tester.Data.Models.Country country, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** BuildAddressComponents

### System.ValueTuple<System.Int32[], System.Int32> ComputeWordLengths(System.Int32 count, System.Int32 minLength, System.Int32 maxLength)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** ComputeWordLengths

### System.Void FillPostalCodeFromFormat(System.Text.StringBuilder sb, System.String format)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** FillPostalCodeFromFormat

### System.Void FillWordChars(System.Span<System.Char> chars, System.ReadOnlySpan<System.Byte> randomBytes, System.Char minCharacter, System.Int32 range)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** FillWordChars

### T GenerateAddress(DotNetTips.Spargine.Tester.Data.Models.Country country, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/4/2025
* **Description:** GenerateAddress
* **Modified By:** David McCarter

### T GenerateAddressCollection(System.Int32& count, System.Int32& addressLength, System.Int32& countyProvinceLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 6/1/2025
* **Description:** GenerateAddressCollection
* **Modified By:** David McCarter

### T GenerateAddressCollection(DotNetTips.Spargine.Tester.Data.Models.Country country, System.Int32 count, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/4/2023
* **Description:** GenerateAddressCollection
* **Modified By:** David McCarter

### System.Byte[] GenerateByteArray(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateByteArray
* **Modified By:** David McCarter

### System.Char GenerateCharacter()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCharacter
* **Modified By:** David McCarter

### System.Char GenerateCharacter(System.Char minValue, System.Char maxValue)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCharacter
* **Modified By:** David McCarter

### T GenerateCoordinate()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCoordinate
* **Modified By:** David McCarter

### T GenerateCoordinateCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCoordinateCollection
* **Modified By:** David McCarter

### System.String GenerateCreditCard()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/13/2023
* **Description:** GenerateCreditCard
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GenerateCreditCards(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/13/2023
* **Description:** GenerateCreditCard
* **Modified By:** David McCarter

### System.Decimal GenerateDecimal(System.Decimal& minValue, System.Decimal& maxValue, System.Int32 decimalPlaces)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateDecimal
* **Modified By:** David McCarter

### System.String GenerateDomainExtension()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateDomainExtension
* **Modified By:** David McCarter

### System.String GenerateEmailAddress()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateEmailAddress
* **Modified By:** David McCarter

### System.String GenerateFile(System.String fileName, System.Int32 fileLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFile
* **Modified By:** David McCarter

### System.ValueTuple<System.String, System.Collections.ObjectModel.ReadOnlyCollection<System.String>> GenerateFiles(System.Int32 count, System.Int32 fileLength, System.String fileExtension)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFiles
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GenerateFiles(System.String path, System.Int32 count, System.Int32 fileLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFiles
* **Modified By:** David McCarter

### System.String GenerateFirstName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/11/2023
* **Description:** GenerateFirstName
* **Modified By:** David McCarter

### System.Int32 GenerateInteger(System.Int32& min, System.Int32 max)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateInteger
* **Modified By:** David McCarter

### System.String GenerateKey()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateKey
* **Modified By:** David McCarter

### System.String GenerateLastName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/11/2023
* **Description:** GenerateLastName
* **Modified By:** David McCarter

### System.Byte[] GenerateNonZeroByteArray(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/21/2025
* **Description:** GenerateNonZeroByteArray
* **Modified By:** David McCarter

### System.String GenerateNumber(System.Int32 length)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateNumber
* **Modified By:** David McCarter

### T GeneratePerson(System.Int32& addressCount, System.Int32& addressLength, System.Int32& countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/4/2025
* **Description:** GeneratePerson
* **Modified By:** David McCarter

### DotNetTips.Spargine.Tester.PersonName GeneratePersonNameInternal()

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** GeneratePersonNameInternal

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.PersonName> GeneratePersonNames(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/15/2023
* **Description:** GeneratePersonNames
* **Modified By:** David McCarter

### DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord GeneratePersonRecord(System.Int32 addressCount, System.Int32& addressLength, System.Int32& countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** GeneratePersonRecord

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> GeneratePersonRecordCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRecordCollection
* **Modified By:** David McCarter

### DotNetTips.Spargine.Tester.Models.RefTypes.Person GeneratePersonRef(System.Int32 addressCount, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRef
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person> GeneratePersonRefCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRefCollection
* **Modified By:** David McCarter

### DotNetTips.Spargine.Tester.Models.ValueTypes.Person GeneratePersonVal(System.Int32 addressCount, System.Int32 addressLength, System.Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonVal
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> GeneratePersonValCollection(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonValCollection
* **Modified By:** David McCarter

### System.String GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.Models.Country country, System.Boolean includeCountryCode)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePhoneNumber
* **Modified By:** David McCarter

### System.String GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName countryName, System.Boolean includeCountryCode)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePhoneNumber
* **Modified By:** David McCarter

### System.String GenerateRandomFileName(System.Int32 fileNameLength, System.String extension)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRandomFileName
* **Modified By:** David McCarter

### System.String GenerateRandomFileName(System.String path, System.Int32 fileNameLength, System.String extension)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRandomFileName
* **Modified By:** David McCarter

### System.ValueTuple<DotNetTips.Spargine.Tester.Data.Models.Country, DotNetTips.Spargine.Tester.Data.Models.State, DotNetTips.Spargine.Tester.Data.Models.City> GenerateRandomLocationData()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** GenerateRandomLocationData

### DotNetTips.Spargine.Tester.PersonData GenerateRandomPersonData()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** GenerateRandomPersonData

### System.ValueTuple<System.String, System.String> GenerateRandomPersonName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** GenerateRandomLocationData

### System.String GenerateRelativeUrl()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRelativeUrl
* **Modified By:** David McCarter

### System.String GenerateTempFile(System.Int32 fileLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateTempFile
* **Modified By:** David McCarter

### System.String GenerateUrl()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrl
* **Modified By:** David McCarter

### System.String GenerateUrlFragment()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlFragment
* **Modified By:** David McCarter

### System.String GenerateUrlHostName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostName
* **Modified By:** David McCarter

### System.String GenerateUrlHostNameNoProtocol()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostNameNoProtocol
* **Modified By:** David McCarter

### System.String GenerateUrlHostNameNoSubDomain()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostNameNoSubDomain
* **Modified By:** David McCarter

### System.String GenerateWord(System.Int32 length)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### System.String GenerateWord(System.Int32 minLength, System.Int32 maxLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### System.String GenerateWord(System.Int32 length, System.Char minCharacter, System.Char maxCharacter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### System.String GenerateWord(System.Int32 minLength, System.Int32 maxLength, System.Char minCharacter, System.Char maxCharacter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> GenerateWords(System.Int32 count, System.Int32 minLength, System.Int32 maxLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWords
* **Modified By:** David McCarter

### DotNetTips.Spargine.Tester.Data.Models.City GetCityFromState(DotNetTips.Spargine.Tester.Data.Models.State state)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** GetCityFromState

### System.String GetCityName(DotNetTips.Spargine.Tester.Data.Models.City city)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** GetCityName

### System.Int32 GetCountryPhoneLength(DotNetTips.Spargine.Tester.Data.Models.Country country)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** GetCountryPhoneLength

### System.String GetPhoneCode(DotNetTips.Spargine.Tester.Data.Models.Country country)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** GetPhoneCode

### System.String GetPhoneCodeString(DotNetTips.Spargine.Tester.Data.Models.Country country)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** GetPhoneCodeString

### System.String GetStateName(DotNetTips.Spargine.Tester.Data.Models.State state)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** GetStateName

### System.String LongTestString { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** LongTestString
* **Modified By:** David McCarter

### System.ValueTuple<DotNetTips.Spargine.Tester.Data.Models.State, DotNetTips.Spargine.Tester.Data.Models.City> PickStateAndCity(DotNetTips.Spargine.Tester.Data.Models.Country country)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** PickStateAndCity

*****
## DotNetTips.Spargine.Tester.UnitTester

### System.Int32 CleanupOutputDirectory(System.String searchPattern)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** CleanupOutputDirectory

### System.TimeSpan MeasureAction(System.Action action, System.Boolean printResult, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** MeasureAction

### System.Threading.Tasks.Task<System.TimeSpan> MeasureActionAsync(System.Func<System.Threading.Tasks.Task> asyncAction, System.Boolean printResult, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** MeasureActionAsync

### System.String OutputDirectory { get; set; }

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** OutputDirectory

### System.Void PrintToDebug(System.String input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** PrintToDebug

### System.Void PrintToDebug(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** PrintToDebug

### System.Void PrintToDebug(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** PrintToDebug

### System.String SaveAsJsonToFile(T input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SaveAsJsonToFile

### System.String SaveToFile(System.String input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SaveToFile

### System.String SaveToFile(System.String input, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** SaveToFile

### System.String SaveToFile(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** SaveToFile

### System.String SaveToFile(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SaveToFile

### System.String SaveToFile(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SaveToFile

### System.String SaveToFile(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** SaveToFile

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(System.String input, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SaveToFileAsync

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** SaveToFileAsync

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(T input, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** SaveToFileAsync

### System.Threading.Tasks.Task<System.String> SaveToFileAsync(T collection, System.Func<System.Reflection.PropertyInfo, System.Boolean> propertySelector, System.IO.DirectoryInfo directory, System.String methodName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Description:** SaveToFileAsync

*****
**Generated by Spargine - dotNetTips.com on 5/21/2026 7:04:12 PM UTC**
