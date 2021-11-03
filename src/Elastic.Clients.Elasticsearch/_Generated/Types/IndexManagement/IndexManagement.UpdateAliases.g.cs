// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases
{
	public interface IActionVariant
	{
		string ActionVariantName { get; }
	}

	[JsonConverter(typeof(ActionConverter))]
	public partial class Action : IContainer
	{
		public Action(IActionVariant variant) => Variant = variant ?? throw new ArgumentNullException(nameof(variant));
		internal IActionVariant Variant { get; }
	}

	public class ActionConverter : JsonConverter<Action>
	{
		public override Action Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			reader.Read();
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException();
			}

			var propertyName = reader.GetString();
			if (propertyName == "add")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases.AddAction?>(ref reader, options);
				reader.Read();
				return new Action(variant);
			}

			if (propertyName == "remove")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases.RemoveAction?>(ref reader, options);
				reader.Read();
				return new Action(variant);
			}

			if (propertyName == "remove_index")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases.RemoveIndexAction?>(ref reader, options);
				reader.Read();
				return new Action(variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, Action value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.Variant.ActionVariantName);
			switch (value.Variant)
			{
				case Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases.AddAction variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases.RemoveAction variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases.RemoveIndexAction variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public partial class AddAction : IActionVariant
	{
		[JsonIgnore]
		string IndexManagement.UpdateAliases.IActionVariant.ActionVariantName => "add";
		[JsonInclude]
		[JsonPropertyName("alias")]
		public Elastic.Clients.Elasticsearch.IndexAlias? Alias { get; set; }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexAlias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_routing")]
		public string? IndexRouting { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_write_index")]
		public bool? IsWriteIndex { get; set; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public string? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_routing")]
		public string? SearchRouting { get; set; }
	}

	public partial class RemoveAction : IActionVariant
	{
		[JsonIgnore]
		string IndexManagement.UpdateAliases.IActionVariant.ActionVariantName => "remove";
		[JsonInclude]
		[JsonPropertyName("alias")]
		public Elastic.Clients.Elasticsearch.IndexAlias? Alias { get; set; }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexAlias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }

		[JsonInclude]
		[JsonPropertyName("must_exist")]
		public bool? MustExist { get; set; }
	}

	public partial class RemoveIndexAction : IActionVariant
	{
		[JsonIgnore]
		string IndexManagement.UpdateAliases.IActionVariant.ActionVariantName => "remove_index";
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }
	}
}