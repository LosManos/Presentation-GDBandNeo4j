using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
	internal static class H
	{
		internal static string ToJson(object o)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
		}

		internal static void Write( string header, object o ){
			Console.WriteLine( "# " + header );
			Console.WriteLine( ToJson(o));
		}
	}
}
