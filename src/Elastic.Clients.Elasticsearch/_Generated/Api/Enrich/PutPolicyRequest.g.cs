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

namespace Elastic.Clients.Elasticsearch.Enrich;

public sealed class PutPolicyRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Creates a new enrich policy.</para>
/// </summary>
public sealed partial class PutPolicyRequest : PlainRequest<PutPolicyRequestParameters>
{
	public PutPolicyRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichPutPolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	[JsonInclude, JsonPropertyName("geo_match")]
	public Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? GeoMatch { get; set; }
	[JsonInclude, JsonPropertyName("match")]
	public Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? Match { get; set; }
	[JsonInclude, JsonPropertyName("range")]
	public Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? Range { get; set; }
}

/// <summary>
/// <para>Creates a new enrich policy.</para>
/// </summary>
public sealed partial class PutPolicyRequestDescriptor<TDocument> : RequestDescriptor<PutPolicyRequestDescriptor<TDocument>, PutPolicyRequestParameters>
{
	internal PutPolicyRequestDescriptor(Action<PutPolicyRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutPolicyRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal PutPolicyRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichPutPolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	public PutPolicyRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? GeoMatchValue { get; set; }
	private EnrichPolicyDescriptor<TDocument> GeoMatchDescriptor { get; set; }
	private Action<EnrichPolicyDescriptor<TDocument>> GeoMatchDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? MatchValue { get; set; }
	private EnrichPolicyDescriptor<TDocument> MatchDescriptor { get; set; }
	private Action<EnrichPolicyDescriptor<TDocument>> MatchDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? RangeValue { get; set; }
	private EnrichPolicyDescriptor<TDocument> RangeDescriptor { get; set; }
	private Action<EnrichPolicyDescriptor<TDocument>> RangeDescriptorAction { get; set; }

	public PutPolicyRequestDescriptor<TDocument> GeoMatch(Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? geoMatch)
	{
		GeoMatchDescriptor = null;
		GeoMatchDescriptorAction = null;
		GeoMatchValue = geoMatch;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> GeoMatch(EnrichPolicyDescriptor<TDocument> descriptor)
	{
		GeoMatchValue = null;
		GeoMatchDescriptorAction = null;
		GeoMatchDescriptor = descriptor;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> GeoMatch(Action<EnrichPolicyDescriptor<TDocument>> configure)
	{
		GeoMatchValue = null;
		GeoMatchDescriptor = null;
		GeoMatchDescriptorAction = configure;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? match)
	{
		MatchDescriptor = null;
		MatchDescriptorAction = null;
		MatchValue = match;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> Match(EnrichPolicyDescriptor<TDocument> descriptor)
	{
		MatchValue = null;
		MatchDescriptorAction = null;
		MatchDescriptor = descriptor;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> Match(Action<EnrichPolicyDescriptor<TDocument>> configure)
	{
		MatchValue = null;
		MatchDescriptor = null;
		MatchDescriptorAction = configure;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> Range(Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? range)
	{
		RangeDescriptor = null;
		RangeDescriptorAction = null;
		RangeValue = range;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> Range(EnrichPolicyDescriptor<TDocument> descriptor)
	{
		RangeValue = null;
		RangeDescriptorAction = null;
		RangeDescriptor = descriptor;
		return Self;
	}

	public PutPolicyRequestDescriptor<TDocument> Range(Action<EnrichPolicyDescriptor<TDocument>> configure)
	{
		RangeValue = null;
		RangeDescriptor = null;
		RangeDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (GeoMatchDescriptor is not null)
		{
			writer.WritePropertyName("geo_match");
			JsonSerializer.Serialize(writer, GeoMatchDescriptor, options);
		}
		else if (GeoMatchDescriptorAction is not null)
		{
			writer.WritePropertyName("geo_match");
			JsonSerializer.Serialize(writer, new EnrichPolicyDescriptor<TDocument>(GeoMatchDescriptorAction), options);
		}
		else if (GeoMatchValue is not null)
		{
			writer.WritePropertyName("geo_match");
			JsonSerializer.Serialize(writer, GeoMatchValue, options);
		}

		if (MatchDescriptor is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchDescriptor, options);
		}
		else if (MatchDescriptorAction is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, new EnrichPolicyDescriptor<TDocument>(MatchDescriptorAction), options);
		}
		else if (MatchValue is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchValue, options);
		}

		if (RangeDescriptor is not null)
		{
			writer.WritePropertyName("range");
			JsonSerializer.Serialize(writer, RangeDescriptor, options);
		}
		else if (RangeDescriptorAction is not null)
		{
			writer.WritePropertyName("range");
			JsonSerializer.Serialize(writer, new EnrichPolicyDescriptor<TDocument>(RangeDescriptorAction), options);
		}
		else if (RangeValue is not null)
		{
			writer.WritePropertyName("range");
			JsonSerializer.Serialize(writer, RangeValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Creates a new enrich policy.</para>
/// </summary>
public sealed partial class PutPolicyRequestDescriptor : RequestDescriptor<PutPolicyRequestDescriptor, PutPolicyRequestParameters>
{
	internal PutPolicyRequestDescriptor(Action<PutPolicyRequestDescriptor> configure) => configure.Invoke(this);

	public PutPolicyRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal PutPolicyRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichPutPolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	public PutPolicyRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? GeoMatchValue { get; set; }
	private EnrichPolicyDescriptor GeoMatchDescriptor { get; set; }
	private Action<EnrichPolicyDescriptor> GeoMatchDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? MatchValue { get; set; }
	private EnrichPolicyDescriptor MatchDescriptor { get; set; }
	private Action<EnrichPolicyDescriptor> MatchDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? RangeValue { get; set; }
	private EnrichPolicyDescriptor RangeDescriptor { get; set; }
	private Action<EnrichPolicyDescriptor> RangeDescriptorAction { get; set; }

	public PutPolicyRequestDescriptor GeoMatch(Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? geoMatch)
	{
		GeoMatchDescriptor = null;
		GeoMatchDescriptorAction = null;
		GeoMatchValue = geoMatch;
		return Self;
	}

	public PutPolicyRequestDescriptor GeoMatch(EnrichPolicyDescriptor descriptor)
	{
		GeoMatchValue = null;
		GeoMatchDescriptorAction = null;
		GeoMatchDescriptor = descriptor;
		return Self;
	}

	public PutPolicyRequestDescriptor GeoMatch(Action<EnrichPolicyDescriptor> configure)
	{
		GeoMatchValue = null;
		GeoMatchDescriptor = null;
		GeoMatchDescriptorAction = configure;
		return Self;
	}

	public PutPolicyRequestDescriptor Match(Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? match)
	{
		MatchDescriptor = null;
		MatchDescriptorAction = null;
		MatchValue = match;
		return Self;
	}

	public PutPolicyRequestDescriptor Match(EnrichPolicyDescriptor descriptor)
	{
		MatchValue = null;
		MatchDescriptorAction = null;
		MatchDescriptor = descriptor;
		return Self;
	}

	public PutPolicyRequestDescriptor Match(Action<EnrichPolicyDescriptor> configure)
	{
		MatchValue = null;
		MatchDescriptor = null;
		MatchDescriptorAction = configure;
		return Self;
	}

	public PutPolicyRequestDescriptor Range(Elastic.Clients.Elasticsearch.Enrich.EnrichPolicy? range)
	{
		RangeDescriptor = null;
		RangeDescriptorAction = null;
		RangeValue = range;
		return Self;
	}

	public PutPolicyRequestDescriptor Range(EnrichPolicyDescriptor descriptor)
	{
		RangeValue = null;
		RangeDescriptorAction = null;
		RangeDescriptor = descriptor;
		return Self;
	}

	public PutPolicyRequestDescriptor Range(Action<EnrichPolicyDescriptor> configure)
	{
		RangeValue = null;
		RangeDescriptor = null;
		RangeDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (GeoMatchDescriptor is not null)
		{
			writer.WritePropertyName("geo_match");
			JsonSerializer.Serialize(writer, GeoMatchDescriptor, options);
		}
		else if (GeoMatchDescriptorAction is not null)
		{
			writer.WritePropertyName("geo_match");
			JsonSerializer.Serialize(writer, new EnrichPolicyDescriptor(GeoMatchDescriptorAction), options);
		}
		else if (GeoMatchValue is not null)
		{
			writer.WritePropertyName("geo_match");
			JsonSerializer.Serialize(writer, GeoMatchValue, options);
		}

		if (MatchDescriptor is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchDescriptor, options);
		}
		else if (MatchDescriptorAction is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, new EnrichPolicyDescriptor(MatchDescriptorAction), options);
		}
		else if (MatchValue is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchValue, options);
		}

		if (RangeDescriptor is not null)
		{
			writer.WritePropertyName("range");
			JsonSerializer.Serialize(writer, RangeDescriptor, options);
		}
		else if (RangeDescriptorAction is not null)
		{
			writer.WritePropertyName("range");
			JsonSerializer.Serialize(writer, new EnrichPolicyDescriptor(RangeDescriptorAction), options);
		}
		else if (RangeValue is not null)
		{
			writer.WritePropertyName("range");
			JsonSerializer.Serialize(writer, RangeValue, options);
		}

		writer.WriteEndObject();
	}
}