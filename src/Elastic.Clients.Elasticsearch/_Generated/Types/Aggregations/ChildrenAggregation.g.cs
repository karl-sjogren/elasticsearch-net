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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class ChildrenAggregation : Aggregations.BucketAggregationBase, IAggregationContainerVariant
	{
		public ChildrenAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "children";
		[JsonInclude]
		[JsonPropertyName("type")]
		public string? Type { get; set; }
	}

	public sealed partial class ChildrenAggregationDescriptor : DescriptorBase<ChildrenAggregationDescriptor>
	{
		public ChildrenAggregationDescriptor()
		{
		}

		internal ChildrenAggregationDescriptor(Action<ChildrenAggregationDescriptor> configure) => configure.Invoke(this);
		internal string? TypeValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal string? NameValue { get; private set; }

		public ChildrenAggregationDescriptor Type(string? type) => Assign(type, (a, v) => a.TypeValue = v);
		public ChildrenAggregationDescriptor Meta(Func<FluentDictionary<string?, object?>, FluentDictionary<string?, object?>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string?, object?>()));
		public ChildrenAggregationDescriptor Name(string? name) => Assign(name, (a, v) => a.NameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (!string.IsNullOrEmpty(NameValue))
			{
				writer.WritePropertyName("name");
				writer.WriteStringValue(NameValue);
			}

			writer.WriteEndObject();
		}
	}
}