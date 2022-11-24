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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Sql;
public sealed class DeleteAsyncRequestParameters : RequestParameters
{
}

public sealed partial class DeleteAsyncRequest : PlainRequest<DeleteAsyncRequestParameters>
{
	public DeleteAsyncRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDeleteAsync;
	internal override HttpMethod HttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
}

public sealed partial class DeleteAsyncRequestDescriptor<TDocument> : RequestDescriptor<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncRequestParameters>
{
	internal DeleteAsyncRequestDescriptor(Action<DeleteAsyncRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public DeleteAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal DeleteAsyncRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDeleteAsync;
	internal override HttpMethod HttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
	public DeleteAsyncRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class DeleteAsyncRequestDescriptor : RequestDescriptor<DeleteAsyncRequestDescriptor, DeleteAsyncRequestParameters>
{
	internal DeleteAsyncRequestDescriptor(Action<DeleteAsyncRequestDescriptor> configure) => configure.Invoke(this);
	public DeleteAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal DeleteAsyncRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDeleteAsync;
	internal override HttpMethod HttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
	public DeleteAsyncRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}