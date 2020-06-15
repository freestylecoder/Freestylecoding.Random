using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Xunit;

namespace Freestylecoding.Random.DataTypes.Tests {
	public class RandomDataTypesTests {
		public static System.Random r = new System.Random( Guid.NewGuid().GetHashCode() );

		internal static void Distribution( int numberOfBuckets, int numberOfSamples, Func<int> bucketSelector ) {
			Dictionary<int, int> buckets = new Dictionary<int, int>();
			int idealBucketSize = numberOfSamples / numberOfBuckets;
			int maxOffset = idealBucketSize / 100;

			Enumerable
				.Range( 0, numberOfBuckets )
				.ToList()
				.ForEach( i => buckets.Add( i, 0 ) );

			Enumerable
				.Range( 0, numberOfSamples )
				.ToList()
				.ForEach( i => {
					int bucket = bucketSelector();
					buckets[bucket] += 1;
				} );

			Assert.False(
				buckets
					.Where( kvp => maxOffset < Math.Abs( kvp.Value - idealBucketSize ) )
					.Any(),
				string.Join( Environment.NewLine,
					new[] { $"maxOffset: {maxOffset}" }
						.Concat(
							buckets
								.Select( kvp => $"{kvp.Key}\t{kvp.Value}\t{kvp.Value - idealBucketSize}" )
						)
				)
			);
		}

		internal static void Distribution( int numberOfBuckets, int numberOfSamples, Func<int,int> bucketSelector ) {
			Dictionary<int, int> buckets = new Dictionary<int, int>();
			int idealBucketSize = numberOfSamples / numberOfBuckets;
			int maxOffset = idealBucketSize / 100;

			Enumerable
				.Range( 0, numberOfBuckets )
				.ToList()
				.ForEach( i => buckets.Add( i, 0 ) );

			Enumerable
				.Range( 0, numberOfSamples )
				.ToList()
				.ForEach( i => {
					int bucket = bucketSelector( i );
					buckets[bucket] += 1;
				} );

			Assert.False(
				buckets
					.Where( kvp => maxOffset < Math.Abs( kvp.Value - idealBucketSize ) )
					.Any(),
				string.Join( Environment.NewLine,
					new[] { $"maxOffset: {maxOffset}" }
						.Concat(
							buckets
								.Select( kvp => $"{kvp.Key}\t{kvp.Value}\t{kvp.Value - idealBucketSize}" )
						)
				)
			);
		}

		[Fact]
		public void Boolean_Distribution() {
			Distribution(
				2,
				100_000,
				() => r.NextBoolean() ? 0 : 1
			);
		}

		[Fact]
		public void Char_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => r.NextChar( 'a', 'k' ) - 'a'
			);
		}

		[Fact]
		public void DateTime_Distribution() {
			DateTime[] values =
				Enumerable
					.Range( 0, 1_000_000 )
					.Select( i => r.NextDateTime( new DateTime( 1897, 1, 1 ), new DateTime( 1904, 1, 1 ) ) )
					.ToArray();

			Distribution(
				7,
				values.Length,
				i => values[i].Year - 1897
			);

			Distribution(
				12,
				values.Length,
				i => values[i].Hour % 12
			);
		}

		[Fact]
		public void Decimal_Range() {
			Assert.Null(
				Record.Exception( () =>
					r.NextDecimal( decimal.MinValue, decimal.MaxValue )
				)
			);
		}

		[Fact]
		public void Decimal_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => Convert.ToInt32( Math.Truncate( r.NextDecimal( 0, 70_000_000_000_000_000_000_000_000_000m ) / 7_000_000_000_000_000_000_000_000_000m ) )
			);
		}

		[Fact]
		public void Double_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => Convert.ToInt32( Math.Truncate( r.NextDouble( 0, 10 ) ) )
			);
		}

		[Fact]
		public void Int16_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => r.NextInt16( 0, 30_000 ) / 3_000 
			);
		}

		[Fact]
		public void Int32_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => r.NextInt32( 0, 2_000_000_000 ) / 200_000_000
			);
		}

		[Fact]
		public void Int64_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => Convert.ToInt32( r.NextInt64( 0, 9_000_000_000_000_000_000 ) / 900_000_000_000_000_000 )
			);
		}

		[Fact]
		public void SByte_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => r.NextSByte( 0, 100 ) % 10
			);
		}

		[Fact]
		public void Single_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => Convert.ToInt32( Math.Truncate( r.NextSingle( 0, 10 ) ) )
			);
		}

		[Fact]
		public void TimeSpan_Distribution() {
			TimeSpan[] values =
				Enumerable
					.Range( 0, 1_000_000 )
					.Select( i => r.NextTimeSpan( TimeSpan.Zero, TimeSpan.FromDays( 10 ) ) )
					.ToArray();

			Distribution(
				10,
				values.Length,
				i => values[i].Days
			);

			Distribution(
				12,
				values.Length,
				i => values[i].Hours % 12
			);

			Distribution(
				10,
				values.Length,
				i => values[i].Minutes % 10
			);

			Distribution(
				10,
				values.Length,
				i => values[i].Seconds % 10
			);
		}

		[Fact]
		public void UInt16_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => r.NextUInt16( 0, 60_000 ) / 6_000
			);
		}

		[Fact]
		public void UInt32_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => Convert.ToInt32( r.NextUInt32( 0, 4_000_000_000 ) / 400_000_000 )
			);
		}

		[Fact]
		public void UInt64_Distribution() {
			Distribution(
				10,
				1_000_000,
				() => Convert.ToInt32( r.NextUInt64( 0, 18_000_000_000_000_000_000 ) / 1_800_000_000_000_000_000 )
			);
		}

		[Fact]
		public void String_Length() {
			Distribution(
				10,
				1_000_000,
				() => r.NextString( 500 ).Length / 50
			);
		}

		[Fact]
		public void String_CharacterDistribution() {
			char[] values =
				Enumerable
					.Range( 0, 1_000 )
					.SelectMany( i => r.NextString( 0, 4000 ) )
					.ToArray();

			Distribution(
				10,
				values.Length,
				( i ) => values[i] % 10
			);
		}
	}
}
