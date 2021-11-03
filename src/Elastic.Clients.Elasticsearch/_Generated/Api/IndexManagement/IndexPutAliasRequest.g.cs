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

using Elastic.Clients.Elasticsearch.Experimental;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexPutAliasRequestParameters : RequestParameters<IndexPutAliasRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class IndexPutAliasRequest : PlainRequestBase<IndexPutAliasRequestParameters>
	{
		public IndexPutAliasRequest(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("index", indices).Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutAlias;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_routing")]
		public string? IndexRouting { get; set; }

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

	[JsonConverter(typeof(IndexPutAliasRequestDescriptorConverter))]
	public partial class IndexPutAliasRequestDescriptor : RequestDescriptorBase<IndexPutAliasRequestDescriptor, IndexPutAliasRequestParameters>
	{
		public IndexPutAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("index", indices).Required("name", name))
		{
		}

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? _filter;
		internal string? _indexRouting;
		internal bool? _isWriteIndex;
		internal string? _routing;
		internal string? _searchRouting;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutAlias;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public IndexPutAliasRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IndexPutAliasRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public IndexPutAliasRequestDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter) => Assign(filter, (a, v) => a._filter = v);
		public IndexPutAliasRequestDescriptor IndexRouting(string? indexRouting) => Assign(indexRouting, (a, v) => a._indexRouting = v);
		public IndexPutAliasRequestDescriptor IsWriteIndex(bool? isWriteIndex = true) => Assign(isWriteIndex, (a, v) => a._isWriteIndex = v);
		public IndexPutAliasRequestDescriptor Routing(string? routing) => Assign(routing, (a, v) => a._routing = v);
		public IndexPutAliasRequestDescriptor SearchRouting(string? searchRouting) => Assign(searchRouting, (a, v) => a._searchRouting = v);
	}

	internal sealed class IndexPutAliasRequestDescriptorConverter : JsonConverter<IndexPutAliasRequestDescriptor>
	{
		public override IndexPutAliasRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexPutAliasRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value._filter is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, value._filter, options);
			}

			if (value._indexRouting is not null)
			{
				writer.WritePropertyName("index_routing");
				JsonSerializer.Serialize(writer, value._indexRouting, options);
			}

			if (value._isWriteIndex.HasValue)
			{
				writer.WritePropertyName("is_write_index");
				writer.WriteBooleanValue(value._isWriteIndex.Value);
			}

			if (value._routing is not null)
			{
				writer.WritePropertyName("routing");
				JsonSerializer.Serialize(writer, value._routing, options);
			}

			if (value._searchRouting is not null)
			{
				writer.WritePropertyName("search_routing");
				JsonSerializer.Serialize(writer, value._searchRouting, options);
			}

			writer.WriteEndObject();
		}
	}
}