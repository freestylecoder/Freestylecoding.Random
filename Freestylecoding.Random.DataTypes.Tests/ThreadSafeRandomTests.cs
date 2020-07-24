using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Freestylecoding.Random.DataTypes.Strings;
using Xunit;

namespace Freestylecoding.Random.DataTypes.Tests {
	public class ThreadSafeRandomTests {
		[Fact]
		public void ThreadSafeTest() {
			ParallelOptions options = new ParallelOptions();
			options.MaxDegreeOfParallelism = -1;
			TestObject[] items = new TestObject[10];

			r = new System.Random();
			Parallel.For( 0, 10, options, i => items[i] = RandomTestObject );
			Assert.Equal( 0, items.Last().Details.Last().MoarNesting.Last().Id );

			r = new ThreadSafeRandom();
			Parallel.For( 0, 10, options, i => items[i] = RandomTestObject );
			Assert.NotEqual( 0, items.Last().Details.Last().MoarNesting.Last().Id );
		}

		
		[Fact]
		public void Next_Distribution() {
			ThreadSafeRandom random = new ThreadSafeRandom();

			RandomDataTypesTests.Distribution(
				10,
				1_000_000,
				() => Math.Abs( random.NextInt32( -2_000_000_000, 2_000_000_000 ) % 10 )
			);
		}

		private static System.Random r;
		private class LastObject {
			public int Id;
			public string Name;
			public DateTime Created;
		}

		private class SubObject {
			public int Id;
			public string Name;
			public DateTime Created;
			public IEnumerable<LastObject> MoarNesting;
		}

		private class TestObject {
			public int Id;
			public string Name;
			public double LuckyValue;
			public IEnumerable<SubObject> Details;
		}

		private static LastObject RandomLastObject => new LastObject {
			Id = r.Next(),
			Name = r.NextWord(),
			Created = r.NextDateTime()
		};
		private static SubObject RandomSubObject => new SubObject {
			Id = r.Next(),
			Name = r.NextWord(),
			Created = r.NextDateTime(),
			MoarNesting = Enumerable.Range( 0, r.Next( 50, 100 ) )
				.Select( i => RandomLastObject )
				.ToList()
		};
		private static TestObject RandomTestObject => new TestObject {
			Id = r.Next(),
			Name = r.NextWord(),
			LuckyValue = r.NextDouble(),
			Details = Enumerable.Range( 0, r.Next( 50, 100 ) )
				.Select( j => RandomSubObject )
				.ToList()
		};
	}
}
