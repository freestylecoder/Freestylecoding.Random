using System;
using System.Linq;
using Freestylecoding.Random.DataTypes.Strings;

namespace TestApp {
	class Program {
		static void Main( string[] args ) {
			Random r = new Random();
			Console.WriteLine( r.NextBlobText( 10000, 100000 ) );
		}
	}
}
