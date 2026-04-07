// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-05-2026
// ***********************************************************************
// <copyright file="DataReaderExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for DataReader.</summary>
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
/// This class includes methods for converting data readers to other formats, such as CSV, with performance optimizations
/// such as using a <see cref="ObjectPool{T}"/> for <see cref="StringBuilder"/> instances to reduce memory allocations.
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

	/// <summary>
	/// Converts <see cref="IDataReader" /> to CSV format using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// Validates that <paramref name="dataReader" /> is not null
	/// </summary>
	/// <param name="dataReader">The data reader.</param>
	/// <param name="includeHeaderAsFirstRow">if set to <c>true</c> [include header as first row].</param>
	/// <param name="delimiter">The delimiter.</param>
	/// <returns>ReadOnlyCollection&lt;System.String&gt;.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(ToCsv), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
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
}
