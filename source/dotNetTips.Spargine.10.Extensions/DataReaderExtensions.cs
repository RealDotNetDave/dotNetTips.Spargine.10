// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="DataReaderExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="System.Data.IDataReader"/> providing data-export utilities.
// Includes <c>ToCsv</c>, which converts an <see cref="System.Data.IDataReader"/> to a
// read-only collection of CSV-formatted strings, with optional header row and configurable
// delimiter. Uses an <see cref="Microsoft.Extensions.ObjectPool.ObjectPool{T}"/> for
// <see cref="System.Text.StringBuilder"/> instances to minimise allocations.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="IDataReader"/> instances, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes <c>ToCsv</c> for converting an <see cref="IDataReader"/> to a read-only collection of
/// CSV-formatted strings. The implementation supports optional header row output and a configurable field delimiter.
/// An <see cref="ObjectPool{T}"/> for <see cref="StringBuilder"/> instances is used internally to reduce
/// per-row heap allocations. String fields containing the delimiter or double-quote characters are automatically
/// escaped according to RFC 4180 conventions.
/// </remarks>
[Information(Status = Status.Available)]
public static class DataReaderExtensions
{

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Converts an <see cref="IDataReader" /> to a read-only collection of CSV-formatted strings,
	/// using an <see cref="ObjectPool{T}"/> for <see cref="StringBuilder"/> instances to improve performance.
	/// </summary>
	/// <param name="dataReader">The data reader to convert. Must not be null.</param>
	/// <param name="includeHeaderAsFirstRow">If <c>true</c>, the first row of the output contains column names as the CSV header.</param>
	/// <param name="delimiter">The field delimiter character. Defaults to <see cref="ControlChars.Comma"/>.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}"/> of <see cref="string"/> where each element represents one CSV row.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="dataReader"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(ToCsv), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> ToCsv([DisallowNull] this IDataReader dataReader, bool includeHeaderAsFirstRow, [ConstantExpected] char delimiter = ControlChars.Comma)
	{
		dataReader = dataReader.ArgumentNotNull();

		var convertedRows = new List<string>();

		AddHeaderRowToCsv(dataReader, includeHeaderAsFirstRow, delimiter, convertedRows);

		while (dataReader.Read())
		{
			var sb = _stringBuilderPool.Get();

			try
			{
				for (var fieldIndex = 0; fieldIndex < dataReader.FieldCount; fieldIndex++)
				{
					if (!dataReader.IsDBNull(fieldIndex))
					{
						var value = dataReader.GetValue(fieldIndex).ToString();
						if (dataReader.GetFieldType(fieldIndex) == typeof(string))
						{
							// If double quotes are used in value, ensure each are replaced by two.
							if (value!.Contains('"', StringComparison.Ordinal))
							{
								value = value.Replace("\"", "\"\"", StringComparison.Ordinal);
							}

							// If delimiter is in value, ensure it is put in double quotes.
							if (value.Contains(delimiter, StringComparison.CurrentCulture))
							{
								value = $"\"{value}\"";
							}
						}

						_ = sb.Append(value);
					}

					if (fieldIndex < dataReader.FieldCount - 1)
					{
						_ = sb.Append(delimiter);
					}
				}

				convertedRows.Add(sb.ToString());
			}
			finally
			{
				_stringBuilderPool.Return(sb.Clear());
			}
		}

		return convertedRows.AsReadOnly();
	}

	/// <summary>
	/// Adds the header row to the CSV output if specified.
	/// </summary>
	/// <param name="dataReader">The data reader.</param>
	/// <param name="includeHeaderAsFirstRow">if set to <c>true</c> [include header as first row].</param>
	/// <param name="delimiter">The delimiter.</param>
	/// <param name="convertedRows">The list of converted rows.</param>
	private static void AddHeaderRowToCsv(IDataReader dataReader, bool includeHeaderAsFirstRow, [ConstantExpected] char delimiter, List<string> convertedRows)
	{
		if (includeHeaderAsFirstRow)
		{
			var sb = _stringBuilderPool.Get();

			try
			{
				for (var fieldIndex = 0; fieldIndex < dataReader.FieldCount; fieldIndex++)
				{
					if (dataReader.GetName(fieldIndex) is not null)
					{
						_ = sb.Append(dataReader.GetName(fieldIndex));
					}

					if (fieldIndex < dataReader.FieldCount - 1)
					{
						_ = sb.Append(delimiter);
					}
				}

				convertedRows.Add(sb.ToString());
			}
			finally
			{
				_stringBuilderPool.Return(sb.Clear());
			}
		}
	}
}
