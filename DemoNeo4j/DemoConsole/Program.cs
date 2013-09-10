using System.Linq;
using Neo4jClient;
using Newtonsoft.Json;
using System;
namespace DemoConsole
{
	public class Person
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		public override string ToString()
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var client = new GraphClient(new Uri("http://localhost:7474/db/data"));
			client.Connect();

			var personNode = client.Get<Person>((NodeReference)6);
			Console.WriteLine("Person-node");
			Console.WriteLine("Person:" + ToString( personNode));
			Console.WriteLine("Person:");
			Console.WriteLine("Person:" + personNode.Data);

			var query = client
				.Cypher
				.Start(new { me = personNode })
				.Match("me-[:FRIEND]->other")
				.Return<Node<Person>>("other");
			var result = query.Results;

			Console.WriteLine("Friends of Ola");
			Console.WriteLine(ToString(result.Select( n => n.Data)));

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}

		private static string ToString(object o)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
		}
	}
}
