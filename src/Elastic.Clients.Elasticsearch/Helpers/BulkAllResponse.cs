// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Elastic.Clients.Elasticsearch.Core.Bulk;

namespace Elastic.Clients.Elasticsearch;

public sealed class BulkAllResponse
{
	/// <summary>This is the Nth buffer.</summary>
	public long Page { get; internal set; }

	/// <summary>The number of back off retries were needed to store this document.</summary>
	public int Retries { get; internal set; }

	/// <summary>The items returned from the bulk response</summary>
	public IReadOnlyCollection<ResponseItem> Items { get; internal set; } = EmptyReadOnly<ResponseItem>.Collection;
}
