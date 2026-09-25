# DotNetTips.Spargine for Microsoft .NET 10: v2026.10.9.1 
![Spargine 10](Docs/Graphics/SPARGINE-10-BANNER-BACKGROUND-100.png)

Open-source .NET assemblies from dotNetTips.com and [**David (dotNetDave) McCarter**](https://dotnettips.wordpress.com/about/). 
This repository hosts the **dotNetTips.Spargine** codebase for .NET 10. Spargine encompasses foundational code that I’ve been building and perfecting since the early days of .NET 2. In addition to the core library, it includes a dedicated library to support efficient testing and another designed specifically for benchmarking your code, helping you achieve optimal performance with ease.

Please support this project by [**clicking here**](https://github.com/sponsors/RealDotNetDave).  

[Click here](https://dotnettips.wordpress.com/spargine/) to visit the Spargine page on **dotNetTips.com**. Much of this code is also documented on  [**dotNetTips.com**](https://dotnettips.wordpress.com/category/open-source/spargine/).
# NuGet
All of the assemblies listed below can be found on NuGet by [clicking here](https://www.nuget.org/profiles/davidmccarter).
# Projects
## Code Quality Stats
### DotNetTips.Spargine
    Unit test coverage: 90.6%
	Benchmark tests: 48
### DotNetTips.Spargine.Core
    Unit test coverage: 88.6%
    Benchmark tests: 1,527
### DotNetTips.Spargine.Extensions
    Unit test coverage: 93.8%
    Benchmark tests: 2,925
### DotNetTips.Spargine.Tester
    Unit test coverage: 94.4%
    Benchmark tests: 225
## Below is the list of classes in this repository
*  	**DotNetTips.Spargine:** Windows and File I/O Targeting Library.
    
    * **IO**
        * **DirectoryHelper**: Common methods for working with file directories.
        * **DriveHelper**: Common methods for working with disk drives.
        * **FileHelper**: Common methods for working with files.
        * **FileProcessor**: Facilitates file copying and deletion operations, incorporating event handling for files. Additionally, it offers the capability to delete folders.
        * **PathHelper**: Common methods for path manipulation, encompassing handling invalid filter characters, invalid path names, and path separators.
        * **TempFileManager**: Creates and maintains a list of temporary files.
        * **OneDriveFolder**: Represents a OneDrive folder, providing details such as account name, account type, directory information, and user email.
    * **Net**
        * **Http**
            * **HttpClientHelper**: Utility methods for HttpClient.
            * **HttpClientOptions**: Holds configuration settings for creating a performance-optimized HttpClient via HttpClientHelper.CreateOptimizedHttpClient.
        * **Sockets**
            * **SocketsHelper**: Helper methods for Socket operations.
    * **Win32**
        * **RegistryHelper**: Convenient methods for interacting with the Windows registration database, streamlining access and manipulation tasks.
    * **ServiceHelper**: Convenient helper methods for seamless management of Windows services, offering key features such as loading a service, checking its running status, starting and stopping services, and more.
    * **ServiceAction**: Represents a service action, encapsulating both the request and the result of the service action, along with the service name.
*   **DotNetTips.Spargine.Core:** Core library used by all of the other assemblies.
    * **Cache**
        * **InMemoryCache**: MemoryCache with a default duration of 20 minutes for storing objects in memory.
        * **CacheStatistics**: Represents cache statistics and metrics.
    * **Collections**
        * **Generic**
            * **OrdinalStringComparer**: Provides ordinal (case-sensitive) string comparison.
            * **Concurrent**
                * **ConcurrentHashSet**: Represents a thread-safe, hash-based unique collection.
                * **DistinctBlockingCollection**: A custom thread-safe collection type designed for multi-threading tasks, ensuring uniqueness for all items in the collection.
                * **DistinctConcurrentBag**: Inherits from ConcurrentBag<T> and ensures that all items in the bag are unique.
            * **AutoDefaultDictionary**: The AutoDefaultDictionary is a specialized dictionary type that automatically returns a predefined default value when a key is not found. This eliminates the need for explicit error handling or null checks when accessing non-existent keys.
            * **FastSortedList**: Custom Collection Class for `<T>`. Items within this collection are sorted only upon request.
            * **ObservableList**: Custom Observable Collection Class for `<T>`. Includes the following events: CollectionChanged, PropertyChanged, PropertyChanging.
        * **CollectionRandomizer**: Designed to shuffle a collection either once or endlessly. Enables users to retrieve items using the GetNext() method.
    * **Data**
        * **CountryPhonePostalInfoRepository**: Provides methods for accessing and validating country phone and postal information.
        * **CountryPhonePostalInfo**: Model representing a country's phone and postal information.
    * **Devices**
        * **Clock**: Time Utility Class for common tasks related to clocks and time. It includes functionalities to retrieve the current time and tick count, along with a method to determine the number of days in the current month (DaysInCurrentMonth).
    * **Diagnostics**
        * **PerformanceStopwatch**: Enhances Stopwatch with helpful methods: StartNew() and StopReset(). Additionally, it possesses the ability to add messages that can be retrieved when the Stopwatch stops.
        * **StopwatchScope**: Measures elapsed time for a scoped operation and optionally reports the result on dispose.
        * **DiagnosticEntry**: Represents a single diagnostic message entry with elapsed timing information.
    * **Logging**
        * **FastLoggerExtentions**: Extension methods for ILogger to simplify logging with enriched messages including the calling method's name.
        * **LoggingHelper**: Utility methods designed for logging purposes. Includes functionality to log computer information and application details. Additionally, it can capture and log all domain exceptions, even if the exception originates from a different assembly, covering exceptions from the .NET framework.
    * **Network**
        * **HttpEventListener**: Listens and logs messages from HTTP events, capturing events such as request start and stop. This functionality facilitates comprehensive monitoring and logging of HTTP-related activities.
        * **HttpEventListenerAsysncLocal**: Listens asynchronously and logs messages from HTTP events, including request start and stop. This functionality enables comprehensive monitoring and logging of asynchronous HTTP-related activities.
        * **HttpHandlerDiagnosticListener**: Accesses the HttpRequestMessage/HttpResponseMessage instances, providing a useful means to retrieve information such as request headers or the response status code.
        * **HttpRequestObserver**: Observes the HttpRequestMessage/HttpResponseMessage instances, offering a valuable method to retrieve information such as request headers or the response status code.
        * **NetworkHelper**: Provides helper methods for network-related operations.
    * **Queues**
        * **ChannelQueue**:  Thread-Safe queue using Channel.
    * **RegularExpressions**
        * **RegexProcessor**: Utility methods for common string regular expressions. Included methods: ContainsWord, IsCreditCardNumber, IsEmailAddress, IsUrl, IsISBN, and more.
    * **Security**
        * **BarCodeGenerator**: Provides HMAC-based barcode generation and validation using HMAC-SHA256 signatures with Crockford Base32 encoding. Supports key rotation, expiry checking, and clock skew tolerance.
        * **Crokford32**: Provides encoding and decoding support for the Crockford Base32 encoding scheme.
        * **EncryptionHelper**: Provides secure encryption for strings using AES (Advanced Encryption Standard) and includes a method to validate encrypted strings. The AES encryption ensures the confidentiality and integrity of sensitive information, making it suitable for securely handling data.
        * **PasswordGenerator**: Provides functionality to generate random passwords with a mix of uppercase letters, lowercase letters, digits, and special characters.
        * **PasswordHasher**: Provides methods for hashing and verifying passwords using multiple algorithms.
    * **Serialization**
        * **JsonSerialization**: This class simplifies the process of serializing and deserializing strings to and from JSON format using the JsonSerializer. JSON serialization is a widely adopted and efficient method for storing and exchanging data in various applications and APIs.
        * **XmlSerialization**: Facilitates seamless serialization and deserialization of strings to and from the XML format.
    * **Threading**
        * **ThreadPoolHelper**: Provides helper methods for executing work on the managed thread pool, including single and batch operations, bounded-concurrency batches, first-to-complete execution, asynchronous and void-returning operations, non-throwing execution via SimpleResult{T}, and thread pool diagnostics. All methods enforce a timeout and support cooperative cancellation.
        * **TaskTracker**: Tracks fire-and-forget and background tasks with ULID registration keys, pending-task inspection, and completion waiting support.
        * **TaskTrackerFacade**: Exposes a shared default task tracker instance and forwarding helpers for registration, unregister, pending-state checks, and completion waiting.
        * **TaskTrackerExtensions**: Extension methods for registering tasks and item-based work with a tracker, including single-item and span-based batch helpers.
        * **ITaskTracker**: Defines the task-tracking contract for registering, unregistering, pending-task inspection, and completion waiting.
    * **Web**
        * **ServiceProxy**: Generates a service proxy for types that implement ICommunicationObject, enabling communication with such objects.
        * **WebHelper**: Utility methods for website calls. These functions streamline website interactions and efficiently manage HTTP-related tasks.
    * **ApiLibraries**: List of common Windows API libraries.
    * **App**: Application Information and Utility Methods.
    * **AppInfo**: Represents application-specific information such as name, version, and environment details.
    * **ArgumentInvalidException**: Custom exception type for invalid argument value.
    * **ArgumentReadOnlyException**: Custom exception type for read-only argument values, such as collections.
    * **AssemblyHelper**: Provides static helper methods for working with assemblies.    
    * **ComputerInfo**: Used to retrieve common computer information.
    * **Config**: Adaptable type designed to simplify the creation of custom configuration objects, with a focus on easy disk saving in applications.
    * **ControlChars**: Contains frequently used strings and characters, including backslash, comma, dash, double quote, empty string, forward slash, quote, space, tab, underscore, and more.
    * **DateTimeFormat**: Provides a set of common date and time formats as strongly-typed enumeration instances.
    * **DirectoryNotFoundException**: Custom exception to be utilized when a directory cannot be found.
    * **Enumeration**: Provides a base class for creating an enumeration-like class structure that supports descriptive names and associated values, offering more flexibility than the standard Enum type.
    * **EnumHelper**: Facilitates the usage of Enums by providing convenient methods such as AdjustCamelCase(), AdjustName(), GetNames(), and more.
    * **EnumValue**: Record holding an enum's name and associated value.
    * **EnvironmentKey**: Enumeration for common environment keys.
    * **ExceptionExtentions**: Provides extension methods for working with exceptions. 
    * **ExceptionThrower**: Inspired by the .NET ExceptionThrower, this tool streamlines the process of throwing exceptions effortlessly. All exceptions thrown utilize default messages, and if necessary, custom messages can also be provided.
    * **ExecutionHelper**: When making calls to code that might be interrupted by network issues, the ProgressiveRetry() method proves beneficial. It automatically retries the code multiple times (default is 3) when encountering connection problems or other internet-related interruptions.
    * **FastStringBuilder**: Enhances performance when using a StringBuilder by employing an ObjectPool.
    * **HtmlElement**: Provides constants for common HTML elements.
    * **ICloneable\<T\>**: Interface defining strongly-typed clone methods for types.
    * **IDataModel**: Interface designed for model classes, enforcing the implementation of the "Id" property, which is mandatory.
    * **IEventInformation**: Marker interface for event information types.
    * **InformationAttribute**: Attribute that enables the addition of informational data to methods. Properties include Author, BenchMarkStatus, CreatedOn, Description, Documentation, ModifiedBy, ModifiedOn, Status, UnitTestCoverage.
    * **InformationAttributeDocGenerator**: Generates documentation for a given type based on the InformationAttribute.
    * **InformationScanner**: Scans types for InformationAttribute metadata.
    * **InvalidEnumTypeException**: Custom exception to be utilized when a value for an Enum is invalid.
    * **InvalidValueException**: Custom exception to be used when an invalid value is encountered.
    * **KeyGenerator**: Generates unique keys using a GUID without dashes.
    * **LineSplitEntry**: Readonly ref struct representing a single line produced during a line-split operation.
    * **LineSplitEnumerator**: Initializes a new instance of the LineSplitEnumerator struct for splitting a string into lines.
    * **MessageNotQueuedException**: Custom exception to be employed when a message could not be queued.
    * **NetworkConnectionException**: Custom exception to be used when there is a network connection error.
    * **PreserveAttribute**: Attribute to make it easier to look at code and know that the code needs to be preserved due to one of the reasons in PreserveReason (None, ObjectInjected, MethodFromInterface, MethodOverride, Other).
    * **ProcessorInformation**: Utility to retrieve information about the computer processor.
    * **ResourceFormatCache**: Provides a thread-safe cache of pre-parsed CompositeFormat instances.
    * **SimpleResult**: Enables methods to return a value, a status, and exception information as needed. This comprehensive approach provides flexibility in handling various outcomes.
    * **Singleton<T>**: Enables easy creation of a singleton type by utilizing Lazy<T> to instantiate the type only when necessary.
    * **TaskHelper**: Synchronous execution methods for Tasks streamline the process of running asynchronous operations without requiring explicit asynchronous handling. This simplifies code readability and management.
    * **TypeHelper**: Provides valuable methods for type management, encompassing tasks such as loading derived types, creating new types, discovering derived types, converting JSON to objects, transforming JSON files into objects, generating instance hash codes, and listing built-in types. These functionalities empower developers to handle types effectively in diverse scenarios.
    * **Ulid**: Represents a Universally Unique Lexicographically Sortable Identifier (ULID).
    * **UnhandledExceptionEventInformation**: Contains information about an unhandled exception captured from an application domain.
    * **Validator**: Methods facilitating the validation of arguments and values, ensuring both simplicity and accuracy. In the event of encountering invalid data, an Exception will be thrown, accompanied by an appropriate error message, which can be either custom or default.
*   **DotNetTips.Spargine.Extensions:** Library for common extension methods. Supported types are: Array, Assembly, Boolean, Character, Collection, Color, CompositeFormat ConcurrentBag, DataContext, DataReader, DataTable, DateTime, DbContext, Dictionary, ModleBuilder Enumerable, Enum, FileInfo, Guid, HashSet,  HttpClient, HttpContext, HttpRequest, HttpReponseHeader, ImmutableArray, LINQ, List, Math, MessagePack Numeric, Object, ObservableCollection, Process, ReadOnlyCollection, ReadOnlySpan, Socket, SortedDictionary, SortedSet, Stream, StringBuilder, String, Task, Thread, Type, WebClient
*   **DotNetTips.Spargine.Tester:** Library for creating dummy data for use in unit & benchmark tests.
    * **Data**:
        * **CountryRepository**: Provides static methods for retrieving comprehensive data about countries, including their regions, states, and cities. Utilizes resources and serialization to efficiently manage and access country data.
        * **Models**
            * **City**: Represents a city with properties for identification and location coordinates.
            * **Country**: Represents detailed information about a country, including name, capital, currency, and geographic data.
            * **State**: Represents a state or province within a country, including cities and geographic coordinates.
            * **Timezone**: Represents timezone information including abbreviation, GMT offset, and display names.
            * **Translations**: Represents translations for various languages.
    * **Extensions**
        * **PersonExtensions**: Provides extension methods for IPerson.
    * **Models**
        * **Common**
            * **IAddress**: Interface "IAddress" that defines properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This interface inherits from another interface named IAddress.  
            * **ICoordinate**: An interface named "ICoordinate" with properties X, Y, and Z for coordinating values.     
            * **IPerson**: Interface "IPerson" that defines properties for Addresses, BornOn, CellPhone, Email, FirstName, LastName, and Phone.
        * **RefTypes**
            * **Comparers**
                * **PersonComparerByIdThenLastName**: Compares two Person instances using a two-level sort: primary by Person.Id (ordinal), then secondary by Person.LastName (ordinal).
                * **PersonComparerByLastName**: Provides a comparison for Person objects based on their last names.
                * **PersonComparerByLastNameThenFirstName**: Provides a comparison for Person objects based on their last names and then first names.
                * **PersonEqualityComparer**: Provides an IEqualityComparer\<Person\> that determines equality by Id.
                * **PersonEqualityComparerByEmail**: Provides equality comparison for Person objects based on email.
                * **PersonRecordEqualityComparerByEmail**: Provides equality comparison for PersonRecord objects based on email.
            * **Address**: Reference type with properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This type inherits from the interface IAddress.
            * **AddressRecord**: Record type with properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This type inherits from the interface IAddress.
            * **Coordinate**: A practical reference type designed for testing and benchmarking, named "Coordinate," featuring properties X, Y, and Z. It inherits from the interface ICoordinate.
            * **Person**: A real-world type for testing and benchmarking named "Person" with the following properties: Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone. This type also includes methods to convert from PersonRecord and Person value types to Person.
            * **PersonRecord**: A real-world type for testing and benchmarking named "PersonRecord" with the following properties: Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone. Additionally, this type includes methods to convert from both Person reference and value types to PersonRecord.
            * **SerializerContexts**
                * **PersonJsonSerializerContext**: JSON context designed to optimize the serialization and deserialization processes for the "Person" type and collections of "Person."
                * **PersonRecordJsonSerializerContext**: JSON context designed to optimize the serialization and deserialization processes for the "PersonRecord" type and collections.
        * **ValueTypes**
            * **Comparers**
                * **PersonComparerByIdThenLastName**: Compares two Person value types using a two-level sort: primary by Person.Id (ordinal), then secondary by Person.LastName (ordinal).
                * **PersonComparerByLastName**: Provides a comparison for Person value types based on their last names.
                * **PersonComparerByLastNameThenFirstName**: Provides a comparison for Person value types based on their last names and then first names.
                * **PersonEqualityComparer**: Provides an IEqualityComparer\<Person\> that determines equality by Id.
                * **PersonEqualityComparerByEmail**: Provides equality comparison for Person value types based on email.
            * **SerializerContexts**
                * **PersonValJsonSerializerContext**: JSON context designed to optimize the serialization and deserialization processes for the value type "Person" and collections.
            * **Address**: Value type named "Address" with properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This type inherits from the interface IAddress.
            * **Coordinate**: A practical value type designed for testing and benchmarking, named "Coordinate," featuring properties X, Y, and Z. It inherits from the interface ICoordinate.
            * **Person**: A real-world value type crafted for testing and benchmarking, named "Person," encompassing properties such as Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone.
    * **PersonData**: Represents person data including personal information and contact details.
    * **PersonName**: Represents a person's name, including first name, last name, and full name.
    * **RandomCreditCardNumberGenerator**: Create random credit card numbers. It includes support for major credit card types such as Visa, MasterCard, American Express, and others.
    * **RandomData**: Create random data for unit and benchmark testing.
    * **UnitTester**: Provides utility methods for debugging and saving object properties. This class is intended to be used as a base class for unit testing scenarios.
*   **DotNetTips.Spargine.Benchmarking:** Library for benchmarking code using BenchmarkDotNet. To read more about this project, [**click here**](source/Benchmarking/README.md).
# Benchmark Tests
Spargine undergoes performance testing through benchmark tests using **BenchmarkDotNet**.
# Your Support Is Appreciated!
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it! **I might just send you some cool geeky swag that includes one of my books (as supplies last).** **You can also support these projects via GitHub Sponsors:** [https://github.com/sponsors/RealDotNetDave](https://github.com/sponsors/RealDotNetDave)
