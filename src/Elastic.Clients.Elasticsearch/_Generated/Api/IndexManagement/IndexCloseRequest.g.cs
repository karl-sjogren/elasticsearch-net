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
	public class IndexCloseRequestParameters : RequestParameters<IndexCloseRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	public partial class IndexCloseRequest : PlainRequestBase<IndexCloseRequestParameters>
	{
		public IndexCloseRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClose;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	[JsonConverter(typeof(IndexCloseRequestDescriptorConverter))]
	public partial class IndexCloseRequestDescriptor : RequestDescriptorBase<IndexCloseRequestDescriptor, IndexCloseRequestParameters>
	{
		public IndexCloseRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClose;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public IndexCloseRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public IndexCloseRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexCloseRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public IndexCloseRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IndexCloseRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public IndexCloseRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	}

	internal sealed class IndexCloseRequestDescriptorConverter : JsonConverter<IndexCloseRequestDescriptor>
	{
		public override IndexCloseRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexCloseRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}