using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Freestylecoding.Random.DataTypes {
	public static class RandomDataTypes {
		#region bool
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static bool NextBoolean( this System.Random random ) =>
			0.5 < random.NextDouble();
		#endregion

		#region char
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static char NextChar( this System.Random random ) => random.NextChar( char.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static char NextChar( this System.Random random, char MaxValue ) => random.NextChar( '\u0000', MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static char NextChar( this System.Random random, char MinValue, char MaxValue ) =>
			Convert.ToChar( random.Next( MinValue, MaxValue ) );
		#endregion

		#region DateTime
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static DateTime NextDateTime( this System.Random random ) => random.NextDateTime( DateTime.MinValue, DateTime.MaxValue );
		public static DateTime NextDateTime( this System.Random random, DateTime MaxValue ) => random.NextDateTime( DateTime.MinValue, MaxValue );
		public static DateTime NextDateTime( this System.Random random, DateTime MinValue, DateTime MaxValue ) =>
			new DateTime( random.NextInt64( MinValue.Ticks, MaxValue.Ticks ) );
		#endregion

		#region decimal
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static decimal NextDecimal( this System.Random random ) => random.NextDecimal( 0, decimal.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static decimal NextDecimal( this System.Random random, decimal MaxValue ) => random.NextDecimal( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static decimal NextDecimal( this System.Random random, decimal MinValue, decimal MaxValue ) =>
			Convert.ToDecimal( random.NextDouble( Convert.ToDouble( MinValue ), Convert.ToDouble( MaxValue ) ) );
		#endregion

		#region double
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static double NextDouble( this System.Random random, double MaxValue ) => random.NextDouble( 0.0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static double NextDouble( this System.Random random, double MinValue, double MaxValue ) =>
			( random.NextDouble() * ( MaxValue - MinValue ) ) + MinValue;
		#endregion

		#region short
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static short NextInt16( this System.Random random ) => random.NextInt16( short.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static short NextInt16( this System.Random random, short MaxValue ) => random.NextInt16( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static short NextInt16( this System.Random random, short MinValue, short MaxValue ) =>
			Convert.ToInt16( random.Next( MinValue, MaxValue ) );
		#endregion

		#region int
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static int NextInt32( this System.Random random ) => random.Next();
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static int NextInt32( this System.Random random, int MaxValue ) => random.Next( MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static int NextInt32( this System.Random random, int MinValue, int MaxValue ) =>
			random.Next( MinValue, MaxValue );
		#endregion

		#region long
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long NextInt64( this System.Random random ) => random.NextInt64( long.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long NextInt64( this System.Random random, long MaxValue ) => random.NextInt64( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long NextInt64( this System.Random random, long MinValue, long MaxValue ) {
			decimal range = Convert.ToDecimal( MaxValue ) - Convert.ToDecimal( MinValue );
			decimal value = Math.Truncate( range * Convert.ToDecimal( random.NextDouble() ) );
			return MinValue + Convert.ToInt64( value );
		}
		#endregion

		#region sbyte
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static sbyte NextSByte( this System.Random random ) => random.NextSByte( sbyte.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static sbyte NextSByte( this System.Random random, sbyte MaxValue ) => random.NextSByte( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static sbyte NextSByte( this System.Random random, sbyte MinValue, sbyte MaxValue ) =>
			Convert.ToSByte( random.Next( MinValue, MaxValue ) );
		#endregion

		#region float
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static float NextSingle( this System.Random random ) => random.NextSingle( float.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static float NextSingle( this System.Random random, float MaxValue ) => random.NextSingle( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static float NextSingle( this System.Random random, float MinValue, float MaxValue ) =>
			Convert.ToSingle( random.NextDouble( MinValue, MaxValue ) );
		#endregion

		#region TimeSpan
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static TimeSpan NextTimeSpan( this System.Random random ) => random.NextTimeSpan( TimeSpan.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static TimeSpan NextTimeSpan( this System.Random random, TimeSpan MaxValue ) => random.NextTimeSpan( TimeSpan.Zero, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static TimeSpan NextTimeSpan( this System.Random random, TimeSpan MinValue, TimeSpan MaxValue ) =>
			new TimeSpan( random.NextInt64( MinValue.Ticks, MaxValue.Ticks ) );
		#endregion

		#region ushort
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ushort NextUInt16( this System.Random random ) => random.NextUInt16( ushort.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ushort NextUInt16( this System.Random random, ushort MaxValue ) => random.NextUInt16( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ushort NextUInt16( this System.Random random, ushort MinValue, ushort MaxValue ) =>
			Convert.ToUInt16( random.Next( MinValue, MaxValue ) );
		#endregion

		#region uint
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static uint NextUInt32( this System.Random random ) => random.NextUInt32( uint.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static uint NextUInt32( this System.Random random, uint MaxValue ) => random.NextUInt32( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static uint NextUInt32( this System.Random random, uint MinValue, uint MaxValue ) =>
			Convert.ToUInt32( random.NextInt64( Convert.ToInt64( MinValue ), Convert.ToInt64( MaxValue ) ) );
		#endregion

		#region ulong
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ulong NextUInt64( this System.Random random ) => random.NextUInt64( ulong.MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ulong NextUInt64( this System.Random random, ulong MaxValue ) => random.NextUInt64( 0, MaxValue );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ulong NextUInt64( this System.Random random, ulong MinValue, ulong MaxValue ) =>
			Convert.ToUInt64( random.NextDecimal( Convert.ToDecimal( MinValue ), Convert.ToDecimal( MaxValue ) ) );
		#endregion

		#region string
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static string NextString( this System.Random random ) => random.NextString( 4000 );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static string NextString( this System.Random random, int MaxLength ) => random.NextString( 0, MaxLength );
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static string NextString( this System.Random random, int MinLength, int MaxLength ) =>
			new string(
				Enumerable
					.Range( 0, random.Next( MinLength, MaxLength ) )
					.Select( i => {
						char rc;

						do rc = random.NextChar();
						while( char.IsControl( rc ) && !char.IsWhiteSpace( rc ) );

						return rc;
					} )
					.ToArray()
			);
		#endregion
	}
}
