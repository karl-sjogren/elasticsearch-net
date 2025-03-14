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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed class ForcemergeRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Whether to expand wildcard expression to concrete indices that are open, closed or both.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>Specify whether the index should be flushed after performing the operation (default: true)</para>
	/// </summary>
	public bool? Flush { get => Q<bool?>("flush"); set => Q("flush", value); }

	/// <summary>
	/// <para>Whether specified concrete indices should be ignored when unavailable (missing or closed)</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>The number of segments the index should be merged into (default: dynamic)</para>
	/// </summary>
	public long? MaxNumSegments { get => Q<long?>("max_num_segments"); set => Q("max_num_segments", value); }

	/// <summary>
	/// <para>Specify whether the operation should only expunge deleted documents</para>
	/// </summary>
	public bool? OnlyExpungeDeletes { get => Q<bool?>("only_expunge_deletes"); set => Q("only_expunge_deletes", value); }

	/// <summary>
	/// <para>Should the request wait until the force merge is completed.</para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>Performs the force merge operation on one or more indices.</para>
/// </summary>
public sealed partial class ForcemergeRequest : PlainRequest<ForcemergeRequestParameters>
{
	public ForcemergeRequest()
	{
	}

	public ForcemergeRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementForcemerge;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	/// <summary>
	/// <para>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Whether to expand wildcard expression to concrete indices that are open, closed or both.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>Specify whether the index should be flushed after performing the operation (default: true)</para>
	/// </summary>
	[JsonIgnore]
	public bool? Flush { get => Q<bool?>("flush"); set => Q("flush", value); }

	/// <summary>
	/// <para>Whether specified concrete indices should be ignored when unavailable (missing or closed)</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>The number of segments the index should be merged into (default: dynamic)</para>
	/// </summary>
	[JsonIgnore]
	public long? MaxNumSegments { get => Q<long?>("max_num_segments"); set => Q("max_num_segments", value); }

	/// <summary>
	/// <para>Specify whether the operation should only expunge deleted documents</para>
	/// </summary>
	[JsonIgnore]
	public bool? OnlyExpungeDeletes { get => Q<bool?>("only_expunge_deletes"); set => Q("only_expunge_deletes", value); }

	/// <summary>
	/// <para>Should the request wait until the force merge is completed.</para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>Performs the force merge operation on one or more indices.</para>
/// </summary>
public sealed partial class ForcemergeRequestDescriptor<TDocument> : RequestDescriptor<ForcemergeRequestDescriptor<TDocument>, ForcemergeRequestParameters>
{
	internal ForcemergeRequestDescriptor(Action<ForcemergeRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ForcemergeRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementForcemerge;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	public ForcemergeRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ForcemergeRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ForcemergeRequestDescriptor<TDocument> Flush(bool? flush = true) => Qs("flush", flush);
	public ForcemergeRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ForcemergeRequestDescriptor<TDocument> MaxNumSegments(long? maxNumSegments) => Qs("max_num_segments", maxNumSegments);
	public ForcemergeRequestDescriptor<TDocument> OnlyExpungeDeletes(bool? onlyExpungeDeletes = true) => Qs("only_expunge_deletes", onlyExpungeDeletes);
	public ForcemergeRequestDescriptor<TDocument> WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public ForcemergeRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Performs the force merge operation on one or more indices.</para>
/// </summary>
public sealed partial class ForcemergeRequestDescriptor : RequestDescriptor<ForcemergeRequestDescriptor, ForcemergeRequestParameters>
{
	internal ForcemergeRequestDescriptor(Action<ForcemergeRequestDescriptor> configure) => configure.Invoke(this);

	public ForcemergeRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementForcemerge;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	public ForcemergeRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ForcemergeRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ForcemergeRequestDescriptor Flush(bool? flush = true) => Qs("flush", flush);
	public ForcemergeRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ForcemergeRequestDescriptor MaxNumSegments(long? maxNumSegments) => Qs("max_num_segments", maxNumSegments);
	public ForcemergeRequestDescriptor OnlyExpungeDeletes(bool? onlyExpungeDeletes = true) => Qs("only_expunge_deletes", onlyExpungeDeletes);
	public ForcemergeRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public ForcemergeRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}