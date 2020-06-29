using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Freestylecoding.Random.DataTypes {
	public static class RandomDataTypes {
		#region bool
		/// <summary>Returns a random boolean value.</summary>
		/// <returns>A random boolean value.</returns>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static bool NextBoolean( this System.Random random ) =>
			0.5 < random.NextDouble();
		#endregion

		#region char
		/// <summary>Returns a random character.</summary>
		/// <returns>A character that is greater than or equal to <see cref="System.Char.MinValue"/> and less than <see cref="System.Char.MaxValue"/>.</returns>
		/// <remarks>
		///		<see cref="Random.DataTypes.RandomDataTypes.NextChar(System.Random)"/> generates a random character whose value ranges from <see cref="System.Char.MinValue"/> to less than <see cref="System.Char.MaxValue"/>.
		///		To generate a random character whose value ranges from <see cref="System.Char.MinValue"/> to some other character, use the <see cref="Random.DataTypes.RandomDataTypes.NextChar(System.Random, char)"/> method overload.
		///		To generate a random character within a different range, use the <see cref="Random.DataTypes.RandomDataTypes.NextChar(System.Random, char, char)"/> method overload.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static char NextChar( this System.Random random ) => random.NextChar( char.MaxValue );
		/// <summary>Returns a random character that is less than the specified maximum.</summary>
		/// <param name="MaxValue">
		///		The exclusive upper bound of the random character to be generated.
		///	</param>
		/// <returns>
		///		A character that is greater than or equal to <see cref="System.Char.MinValue"/>, and less than maxValue; that is, the range of return values ordinarily includes <see cref="System.Char.MinValue"/> but not maxValue.
		///		However, if maxValue equals <see cref="System.Char.MinValue"/>, maxValue is returned.
		/// </returns>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextChar(System.Random, char)"/> overload returns random characters that range from <see cref="System.Char.MinValue"/> to the Unicode character before maxValue.
		///		However, if maxValue is <see cref="System.Char.MinValue"/>, the method returns <see cref="System.Char.MinValue"/>.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static char NextChar( this System.Random random, char MaxValue ) => random.NextChar( '\u0000', MaxValue );
		/// <summary>Returns a random character that is within a specified range.</summary>
		/// <param name="MinValue">The inclusive lower bound of the random character returned.</param>
		/// <param name="MaxValue">
		///		The exclusive upper bound of the random character returned.
		///		maxValue must be greater than or equal to minValue.
		///	</param>
		/// <returns>
		///		A character greater than or equal to minValue and less than maxValue; that is, the range of return values includes minValue but not maxValue.
		///		If minValue equals maxValue, minValue is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException">minValue is greater than maxValue.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextChar(System.Random, char, char)"/> overload returns random integers that range from minValue to the Unicode character before maxValue.
		///		However, if maxValue equals minValue, the method returns minValue.
		/// </remarks>
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
		/// <summary>Returns a random double-precision floating-point number that is greater than or equal to 0.0, and less than the specified maximum.</summary>
		/// <param name="MaxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		maxValue must be greater than or equal to 0.0.
		///	</param>
		/// <returns>
		///		A double-precision floating point number that is greater than or equal to 0.0, and less than maxValue; that is, the range of return values ordinarily includes 0.0 but not maxValue.
		///		However, if maxValue equals 0.0, maxValue is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException">maxValue is less than 0.0.</exception>
		/// <remarks>
		///		The NextDouble(Double) overload returns random double-precision floating point numbers that range from 0.0 to maxValue – 0.00000000000000022.
		///		However, if maxValue is 0.0, the method returns 0.0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static double NextDouble( this System.Random random, double MaxValue ) => random.NextDouble( 0.0, MaxValue );
		/// <summary>Returns a random double-precision floating point number that is within a specified range.</summary>
		/// <param name="MinValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="MaxValue">
		///		The exclusive upper bound of the random number returned.
		///		maxValue must be greater than or equal to minValue.
		///	</param>
		/// <returns>
		///		A double-precision floating point number greater than or equal to minValue and less than maxValue; that is, the range of return values includes minValue but not maxValue.
		///		If minValue equals maxValue, minValue is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException">minValue is greater than maxValue.</exception>
		/// <remarks>
		///		<para>
		///			The NextDouble(Double, Double) overload returns random integers that range from minValue to maxValue – 0.00000000000000022.
		///			However, if maxValue equals minValue, the method returns minValue.
		///		</para>
		///		<para>Unlike the other overloads of the NextDouble method, which return only non-negative values, this method can return a negative random double-precision floating point number.</para>
		/// </remarks>
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
		/// <summary>Returns a non-negative random integer.</summary>
		/// <returns>A 32-bit signed integer that is greater than or equal to 0 and less than <see cref="System.Int32.MaxValue"/>.</returns>
		/// <remarks>
		///		<see cref="Random.DataTypes.RandomDataTypes.NextInt32(System.Random)"/> generates a random number whose value ranges from 0 to less than <see cref="System.Int32.MaxValue"/>.
		///		To generate a random number whose value ranges from 0 to some other positive number, use the <see cref="Random.DataTypes.RandomDataTypes.NextInt32(System.Random, int)"/> method overload.
		///		To generate a random number within a different range, use the <see cref="Random.DataTypes.RandomDataTypes.NextInt32(System.Random, int, int)"/> method overload.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static int NextInt32( this System.Random random ) => random.Next();
		/// <summary>Returns a non-negative random integer that is less than the specified maximum.</summary>
		/// <param name="MaxValue">The exclusive upper bound of the random number to be generated. maxValue must be greater than or equal to 0.</param>
		/// <returns>
		///		A 32-bit signed integer that is greater than or equal to 0, and less than maxValue; that is, the range of return values ordinarily includes 0 but not maxValue.
		///		However, if maxValue equals 0, maxValue is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException">maxValue is less than 0.</exception>
		/// <remarks>
		///		The NextInt32(Int32) overload returns random integers that range from 0 to maxValue – 1.
		///		However, if maxValue is 0, the method returns 0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static int NextInt32( this System.Random random, int MaxValue ) => random.Next( MaxValue );
		/// <summary>Returns a random integer that is within a specified range.</summary>
		/// <param name="MinValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="MaxValue">
		///		The exclusive upper bound of the random number returned.
		///		maxValue must be greater than or equal to minValue.
		///	</param>
		/// <returns>
		///		A 32-bit signed integer greater than or equal to minValue and less than maxValue; that is, the range of return values includes minValue but not maxValue.
		///		If minValue equals maxValue, minValue is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException">minValue is greater than maxValue.</exception>
		/// <remarks>
		///		<para>
		///			The NextInt32(Int32, Int32) overload returns random integers that range from minValue to maxValue – 1.
		///			However, if maxValue equals minValue, the method returns minValue.
		///		</para>
		///		<para>Unlike the other overloads of the NextInt32 method, which return only non-negative values, this method can return a negative random integer.</para>
		/// </remarks>
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
