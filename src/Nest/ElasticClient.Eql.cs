// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.EqlApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.EqlApi
{
	///<summary>
	/// Eql APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.Eql"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class EqlNamespace : NamespacedClientProxy
	{
		internal EqlNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>DELETE</c> request to the <c>eql.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlDeleteResponse Delete(Id id, Func<EqlDeleteDescriptor, IEqlDeleteRequest> selector = null) => Delete(selector.InvokeOrDefault(new EqlDeleteDescriptor(id: id)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>eql.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlDeleteResponse> DeleteAsync(Id id, Func<EqlDeleteDescriptor, IEqlDeleteRequest> selector = null, CancellationToken ct = default) => DeleteAsync(selector.InvokeOrDefault(new EqlDeleteDescriptor(id: id)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>eql.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlDeleteResponse Delete(IEqlDeleteRequest request) => DoRequest<IEqlDeleteRequest, EqlDeleteResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>eql.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlDeleteResponse> DeleteAsync(IEqlDeleteRequest request, CancellationToken ct = default) => DoRequestAsync<IEqlDeleteRequest, EqlDeleteResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlGetResponse<TDocument> Get<TDocument>(Id id, Func<EqlGetDescriptor, IEqlGetRequest> selector = null)
			where TDocument : class => Get<TDocument>(selector.InvokeOrDefault(new EqlGetDescriptor(id: id)));
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlGetResponse<TDocument>> GetAsync<TDocument>(Id id, Func<EqlGetDescriptor, IEqlGetRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => GetAsync<TDocument>(selector.InvokeOrDefault(new EqlGetDescriptor(id: id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlGetResponse<TDocument> Get<TDocument>(IEqlGetRequest request)
			where TDocument : class => DoRequest<IEqlGetRequest, EqlGetResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlGetResponse<TDocument>> GetAsync<TDocument>(IEqlGetRequest request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<IEqlGetRequest, EqlGetResponse<TDocument>>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlSearchStatusResponse SearchStatus(Id id, Func<EqlSearchStatusDescriptor, IEqlSearchStatusRequest> selector = null) => SearchStatus(selector.InvokeOrDefault(new EqlSearchStatusDescriptor(id: id)));
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlSearchStatusResponse> SearchStatusAsync(Id id, Func<EqlSearchStatusDescriptor, IEqlSearchStatusRequest> selector = null, CancellationToken ct = default) => SearchStatusAsync(selector.InvokeOrDefault(new EqlSearchStatusDescriptor(id: id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlSearchStatusResponse SearchStatus(IEqlSearchStatusRequest request) => DoRequest<IEqlSearchStatusRequest, EqlSearchStatusResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>eql.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlSearchStatusResponse> SearchStatusAsync(IEqlSearchStatusRequest request, CancellationToken ct = default) => DoRequestAsync<IEqlSearchStatusRequest, EqlSearchStatusResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>eql.search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlSearchResponse<TDocument> Search<TInferDocument, TDocument>(Func<EqlSearchDescriptor<TInferDocument>, IEqlSearchRequest> selector = null)
			where TInferDocument : class where TDocument : class => Search<TDocument>(selector.InvokeOrDefault(new EqlSearchDescriptor<TInferDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>eql.search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlSearchResponse<TDocument>> SearchAsync<TInferDocument, TDocument>(Func<EqlSearchDescriptor<TInferDocument>, IEqlSearchRequest> selector = null, CancellationToken ct = default)
			where TInferDocument : class where TDocument : class => SearchAsync<TDocument>(selector.InvokeOrDefault(new EqlSearchDescriptor<TInferDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>eql.search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlSearchResponse<TDocument> Search<TDocument>(Func<EqlSearchDescriptor<TDocument>, IEqlSearchRequest> selector = null)
			where TDocument : class => Search<TDocument>(selector.InvokeOrDefault(new EqlSearchDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>eql.search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlSearchResponse<TDocument>> SearchAsync<TDocument>(Func<EqlSearchDescriptor<TDocument>, IEqlSearchRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => SearchAsync<TDocument>(selector.InvokeOrDefault(new EqlSearchDescriptor<TDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>eql.search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public EqlSearchResponse<TDocument> Search<TDocument>(IEqlSearchRequest request)
			where TDocument : class => DoRequest<IEqlSearchRequest, EqlSearchResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>eql.search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</a>
		/// </summary>
		public Task<EqlSearchResponse<TDocument>> SearchAsync<TDocument>(IEqlSearchRequest request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<IEqlSearchRequest, EqlSearchResponse<TDocument>>(request, request.RequestParameters, ct);
	}
}