using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
	internal class Person
	{
		[JsonProperty("name")]
		internal string Name { get; set; }

		public override string ToString()
		{
			return H.ToJson(this);
		}
	}
}
