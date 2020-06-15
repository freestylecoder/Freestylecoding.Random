using System;
using System.Linq;
using Freestylecoding.Random.DataTypes.Strings;

namespace TestApp {
	class Program {
		static void Main( string[] args ) {
			Random r = new Random();

			//foreach( int i in Enumerable.Range( 0, 20 ) )
				Console.WriteLine( r.NextBlobText( 1000, 10000 ) );
		}
	}
}
