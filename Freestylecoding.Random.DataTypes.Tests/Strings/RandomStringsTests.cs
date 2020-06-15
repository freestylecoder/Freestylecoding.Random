using System;
using System.Linq;
using Freestylecoding.Random.DataTypes.Strings;
using Xunit;

namespace Freestylecoding.Random.DataTypes.Tests.Strings {
	public class RandomStringsTests {
		public static System.Random r = new System.Random( Guid.NewGuid().GetHashCode() );

		[Fact]
		public void NextWord_Randomness() {
			//string lastWord = null;
			//string nextWord = null;

			//foreach( int i in Enumerable.Range( 0, 100_000 ) ) {
			//	nextWord = r.NextWord();
			//	Assert.NotEqual( lastWord, nextWord );
			//	lastWord = nextWord;
			//}
		}
	}
}
