using System.Linq;
using Neo4jClient;
using Newtonsoft.Json;
using System;
namespace DemoConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new GraphClient(new Uri("http://localhost:7474/db/data"));
			client.Connect();

			var personNode = client.Get<Person>((NodeReference)6);
			H.Write("Person-node", personNode);
			H.Write("Person-id:", personNode.Reference.Id);
			H.Write("Person:", personNode.Data);

			var query = client
				.Cypher
				.Start(new { me = personNode })
				.Match("me-[:FRIEND]->other")
				.Return<Node<Person>>("other");
			var result = query.Results;

			H.Write("Friends of Ola", result.Select( n => n.Data));

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}
}
