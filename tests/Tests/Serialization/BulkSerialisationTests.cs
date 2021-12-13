// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Tests.Domain;

namespace Tests.Serialization
{
	public class BulkSerialisationTests : SourceSerializerTestBase
	{
		[U]
		public void BulkRequestSerialisationTest()
		{
			var expectedJson = @"{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
";

			expectedJson = expectedJson.Replace("\r\n", "\n", System.StringComparison.Ordinal);

			var operations = new BulkOperationsCollection
			{
				new BulkIndexOperation<Project>(_fixedProject) { Index = "project" },
				new BulkIndexOperation<Project>(_fixedProject) { Index = "project" }
			};

			var request = new BulkRequest<Project>
			{
				Operations = operations
			};

			var serialisedJson = SerializeAndGetJsonString(request);
			serialisedJson.Should().Be(expectedJson);
		}

		[U]
		public void BulkRequestDescriptorSerialisationTest()
		{
			var expectedJson = @"{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
";

			expectedJson = expectedJson.Replace("\r\n", "\n", System.StringComparison.Ordinal);

			var request = new BulkRequestDescriptor<Project>();
			request.Index(_fixedProject, b => b.Index("project"));
			request.Index(_fixedProject);

			var serialisedJson = SerializeAndGetJsonString(request);
			serialisedJson.Should().Be(expectedJson);
		}

		private static readonly Project _fixedProject = new Project
		{
			LeadDeveloper = new Developer
			{
				FirstName = "Steve",
				LastName = "Gordon",
				Gender = Gender.Male
			}
		};
	}
}