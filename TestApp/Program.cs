using System;
using System.Linq;
using Freestylecoding.Random.DataTypes;
using Freestylecoding.Random.DataTypes.Strings;

namespace TestApp {
	class Program {
		static void Main( string[] args ) {
			Random r = new Random();

			//for( int i = 0; i < int.MaxValue; ++i ) {
			//	if( 0 == ( i % 100_000 ) )
			//		Console.WriteLine( i );

			//	if( 1f == r.NextSingle() )
			//		Console.WriteLine( "TRUE" );
			//}

			Console.WriteLine( "{0:F25}", Convert.ToDecimal( 0.99999999999999978 ) );
		}
	}
}
