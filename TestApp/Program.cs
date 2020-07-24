using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Freestylecoding.Random;
using Freestylecoding.Random.DataTypes;
using Freestylecoding.Random.DataTypes.Strings;

namespace TestApp {
	class LastObject {
		public int Id;
		public string Name;
		public DateTime Created;

		public override string ToString() =>
			$"{{ Id = {Id}, Name = {Name}, Created = {Created} }}";
	}

	class SubObject {
		public int Id;
		public string Name;
		public DateTime Created;
		public IEnumerable<LastObject> MoarNesting;

		public override string ToString() =>
			$"{{ Id = {Id}, Name = {Name}, Created = {Created}, MoarNesting = [ {string.Join( ", ", MoarNesting.Select( x => x.Id.ToString() ) )} ] }}";
	}

	class TestObject {
		public int Id;
		public string Name;
		public double LuckyValue;
		public IEnumerable<SubObject> Details;

		public override string ToString() {
			StringBuilder s = new StringBuilder();
			s.AppendLine( "{" );
			s.AppendLine( $"	Id = {Id}," );
			s.AppendLine( $"	Name = {Name}" );
			s.AppendLine( $"	LuckyValue = {LuckyValue}," );
			s.AppendLine( $"	Details = [" );
			s.AppendLine( string.Join( $",{Environment.NewLine}", Details.Select( s => $"		{s}" ) ) );
			s.AppendLine( $"	]" );
			s.AppendLine( "}" );

			return s.ToString();
		}
	}

	class Program {
		//static Random r = new Random();
		static Random r = new ThreadSafeRandom();

		static LastObject RandomLastObject => new LastObject {
			Id = r.Next(),
			Name = r.NextWord(),
			Created = r.NextDateTime()
		};
		static SubObject RandomSubObject => new SubObject {
			Id = r.Next(),
			Name = r.NextWord(),
			Created = r.NextDateTime(),
			MoarNesting = Enumerable.Range( 0, r.Next( 50, 100 ) )
				.Select( i => RandomLastObject )
				.ToList()
		};
		static TestObject RandomTestObject => new TestObject {
			Id = r.Next(),
			Name = r.NextWord(),
			LuckyValue = r.NextDouble(),
			Details = Enumerable.Range( 0, r.Next( 50, 100 ) )
				.Select( j => RandomSubObject )
				.ToList()
		};

		static void Main( string[] args ) {
			ParallelOptions options = new ParallelOptions();
			options.MaxDegreeOfParallelism = -1;

			TestObject[] items = new TestObject[100_000];
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

			sw.Restart();
			Parallel.For( 0, 10, options, i => items[i] = RandomTestObject );
			sw.Stop();
			//sw.Restart();
			//Parallel.For( 0, 100, options, i => items[i] = RandomTestObject );
			//sw.Stop();
			//Console.WriteLine( $"{DateTime.Now} ~ {sw.Elapsed}" );
			//sw.Restart();
			//Parallel.For( 0, 1_000, options, i => items[i] = RandomTestObject );
			//sw.Stop();
			//Console.WriteLine( $"{DateTime.Now} ~ {sw.Elapsed}" );
			//sw.Restart();
			//Parallel.For( 0, 10_000, options, i => items[i] = RandomTestObject );
			//sw.Stop();
			//Console.WriteLine( $"{DateTime.Now} ~ {sw.Elapsed}" );
			//sw.Restart();
			//Parallel.For( 0, 100_000, options, i => items[i] = RandomTestObject );
			//sw.Stop();
			//Console.WriteLine( $"{DateTime.Now} ~ {sw.Elapsed}" );

			Console.WriteLine( items[0] );
			//Console.WriteLine( items[9] );
			Console.WriteLine( $"{DateTime.Now} ~ {sw.Elapsed}" );
		}
	}
}
