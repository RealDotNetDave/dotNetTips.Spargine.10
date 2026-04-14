// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="WebClientExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for WebClient.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="WebClient"/> to enhance its functionality,
/// including methods for converting JSON data to objects.
/// </summary>
[Obsolete("The WebClient class is considered obsolete. Consider using HttpClient for modern applications. This type will be removed in a future version.", true)]
[Information(Status = Status.Available)]
public static class WebClientExtensions
{

	/// <summary>
	/// Converts JSON data from a specified URL into an object of type <typeparamref name="T"/>.
	/// Validates that <paramref name="client"/> and <paramref name="url"/> are not null.
	/// </summary>
	/// <typeparam name="T">The type of the object to convert to.</typeparam>
	/// <param name="client">The <see cref="WebClient"/> instance. This parameter cannot be null.</param>
	/// <param name="url">The URL to download JSON data from. This parameter cannot be null.</param>
	/// <returns>An instance of type <typeparamref name="T"/> populated with data from the JSON string; otherwise, null if the JSON data is empty.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is null.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="url"/> is null.</exception>
	[Obsolete("The WebClient class is considered obsolete. Consider using HttpClient for modern applications. This type will be removed in a future version.", true)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(ConvertFrom), OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T? ConvertFrom<T>([DisallowNull] this WebClient client, [DisallowNull] Uri url)
		where T : class
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();

		var data = client.DownloadString(url);

		if (string.IsNullOrEmpty(data))
		{
			return null;
		}

		using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
		{
			var serializer = new DataContractJsonSerializer(typeof(T));
			var obj = (T)serializer.ReadObject(stream)!;

			return obj;
		}
	}

}
