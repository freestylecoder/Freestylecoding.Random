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
		/// <param name="maxValue">
		///		The exclusive upper bound of the random character to be generated.
		///	</param>
		/// <returns>
		///		A character that is greater than or equal to <see cref="System.Char.MinValue"/>, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes <see cref="System.Char.MinValue"/> but not maxValue.
		///		However, if <paramref name="maxValue"/> equals <see cref="System.Char.MinValue"/>, <paramref name="maxValue"/> is returned.
		/// </returns>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextChar(System.Random, char)"/> overload returns random characters that range from <see cref="System.Char.MinValue"/> to the Unicode character before <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> is <see cref="System.Char.MinValue"/>, the method returns <see cref="System.Char.MinValue"/>.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static char NextChar( this System.Random random, char maxValue ) => random.NextChar( '\u0000', maxValue );
		/// <summary>Returns a random character that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random character returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random character returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A character greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextChar(System.Random, char, char)"/> overload returns random characters that range from <paramref name="minValue"/> to the Unicode character before <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static char NextChar( this System.Random random, char minValue, char maxValue ) =>
			Convert.ToChar( random.Next( minValue, maxValue ) );
		#endregion

		#region DateTime
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static DateTime NextDateTime( this System.Random random ) => random.NextDateTime( DateTime.MinValue, DateTime.MaxValue );
		public static DateTime NextDateTime( this System.Random random, DateTime MaxValue ) => random.NextDateTime( DateTime.MinValue, MaxValue );
		public static DateTime NextDateTime( this System.Random random, DateTime MinValue, DateTime MaxValue ) =>
			new DateTime( random.NextInt64( MinValue.Ticks, MaxValue.Ticks ) );
		#endregion

		#region decimal
		/// <summary>Returns a random decimal number that is greater than or equal to 0m, and less 1m.</summary>
		/// <returns>
		///		A decimal that is greater than or equal to 0m, and less than 1m.
		/// </returns>
		/// <remarks>
		///		<para>
		///			Due to rounding errors with decimals, there is an EXTREMELY small chance that 1m will be selected.
		///			If this is a concern, please add checks in the client code.
		///		</para>	
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static decimal NextDecimal( this System.Random random ) => random.NextDecimal( 0, decimal.MaxValue );
		/// <summary>Returns a random decimal number that is greater than or equal to 0m, and less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0m.
		///	</param>
		/// <returns>
		///		A decimal number that is greater than or equal to 0m, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0m but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0m, 0m is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0m.</exception>
		/// <remarks>
		///		<para>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextDecimal(System.Random, decimal)"/> overload returns random decimal numbers that range from 0M to <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> is 0m, the method returns 0m.
		///		</para>
		///		<para>
		///			Due to rounding errors with decimals, there is an EXTREMELY small chance that <paramref name="maxValue"/> will be selected.
		///			If this is a concern, please add checks in the client code.
		///		</para>	
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static decimal NextDecimal( this System.Random random, decimal maxValue ) => random.NextDecimal( 0, maxValue );
		/// <summary>Returns a decimal number that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A decimal number greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextDouble(System.Random, decimal, decimal)"/> overload returns random double-precision floating-point that range from <paramref name="minValue"/> to <paramref name="maxValue"/>.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		///		<para>Unlike the other overloads of the NextDecimal method, which return only non-negative values, this method can return a negative random decimal number.</para>
		///		<para>
		///			Due to rounding errors with decimals, there is an EXTREMELY small chance that <paramref name="maxValue"/> will be selected.
		///			If this is a concern, please add checks in the client code.
		///		</para>	
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static decimal NextDecimal( this System.Random random, decimal minValue, decimal maxValue ) =>
			Convert.ToDecimal( random.NextDouble( Convert.ToDouble( minValue ), Convert.ToDouble( maxValue ) ) );
		#endregion

		#region double
		/// <summary>Returns a random double-precision floating-point number that is greater than or equal to 0.0, and less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0.0.
		///	</param>
		/// <returns>
		///		A double-precision floating point number that is greater than or equal to 0.0, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0.0 but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0.0, 0.0 is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.0.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextDouble(System.Random, double)"/> overload returns random double-precision floating point numbers that range from 0.0 to <paramref name="maxValue"/> – 0.00000000000000022.
		///		However, if <paramref name="maxValue"/> is 0.0, the method returns 0.0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static double NextDouble( this System.Random random, double maxValue ) => random.NextDouble( 0.0, maxValue );
		/// <summary>Returns a random double-precision floating point number that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A double-precision floating point number greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextDouble(System.Random, double, double)"/> overload returns random double-precision floating-point that range from <paramref name="minValue"/> to <paramref name="maxValue"/> – 0.00000000000000022.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		///		<para>Unlike the other overloads of the NextDouble method, which return only non-negative values, this method can return a negative random double-precision floating point number.</para>
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static double NextDouble( this System.Random random, double minValue, double maxValue ) =>
			( random.NextDouble() * ( maxValue - minValue ) ) + minValue;
		#endregion

		#region short
		/// <summary>Returns a non-negative random short.</summary>
		/// <returns>A 16-bit signed integer that is greater than or equal to 0 and less than <see cref="System.Int16.MaxValue"/>.</returns>
		/// <remarks>
		///		<see cref="Random.DataTypes.RandomDataTypes.NextInt16(System.Random)"/> generates a random number whose value ranges from 0 to less than <see cref="System.Int16.MaxValue"/>.
		///		To generate a random number whose value ranges from 0 to some other positive number, use the <see cref="Random.DataTypes.RandomDataTypes.NextInt16(System.Random, short)"/> method overload.
		///		To generate a random number within a different range, use the <see cref="Random.DataTypes.RandomDataTypes.NextInt16(System.Random, short, short)"/> method overload.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static short NextInt16( this System.Random random ) => random.NextInt16( short.MaxValue );
		/// <summary>Returns a non-negative random short that is less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0.
		///	</param>
		/// <returns>
		///		A 16-bit signed integer that is greater than or equal to 0, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0, 0 is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextInt16(System.Random, short)"/> overload returns random integers that range from 0 to <paramref name="maxValue"/> – 1.
		///		However, if <paramref name="maxValue"/> is 0, the method returns 0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static short NextInt16( this System.Random random, short maxValue ) => random.NextInt16( 0, maxValue );
		/// <summary>Returns a random short that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A 16-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextInt16(System.Random, short, short)"/> overload returns random integers that range from <paramref name="minValue"/> to maxValue – 1.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		///		<para>Unlike the other overloads of the NextInt16 method, which return only non-negative values, this method can return a negative random integer.</para>
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static short NextInt16( this System.Random random, short minValue, short maxValue ) =>
			Convert.ToInt16( random.Next( minValue, maxValue ) );
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
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0.</param>
		/// <returns>
		///		A 32-bit signed integer that is greater than or equal to 0, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0, 0 is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextInt32(System.Random, int)"/> overload returns random integers that range from 0 to <paramref name="maxValue"/> – 1.
		///		However, if <paramref name="maxValue"/> is 0, the method returns 0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static int NextInt32( this System.Random random, int maxValue ) => random.Next( maxValue );
		/// <summary>Returns a random integer that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A 32-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextInt32(System.Random, int, int)"/> overload returns random integers that range from <paramref name="minValue"/> to <paramref name="maxValue"/> – 1.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		///		<para>Unlike the other overloads of the NextInt32 method, which return only non-negative values, this method can return a negative random integer.</para>
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static int NextInt32( this System.Random random, int minValue, int maxValue ) =>
			random.Next( minValue, maxValue );
		#endregion

		#region long
		/// <summary>Returns a non-negative random long.</summary>
		/// <returns>A 64-bit signed integer that is greater than or equal to 0 and less than <see cref="System.Int64.MaxValue"/>.</returns>
		/// <remarks>
		///		<see cref="Random.DataTypes.RandomDataTypes.NextInt64(System.Random)"/> generates a random number whose value ranges from 0 to less than <see cref="System.Int64.MaxValue"/>.
		///		To generate a random number whose value ranges from 0 to some other positive number, use the <see cref="Random.DataTypes.RandomDataTypes.NextInt64(System.Random, long)"/> method overload.
		///		To generate a random number within a different range, use the <see cref="Random.DataTypes.RandomDataTypes.NextInt64(System.Random, long, long)"/> method overload.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long NextInt64( this System.Random random ) => random.NextInt64( long.MaxValue );
		/// <summary>Returns a non-negative random long that is less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0.</param>
		/// <returns>
		///		A 64-bit signed integer that is greater than or equal to 0, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0, 0 is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextInt64(System.Random, long)"/> overload returns random integers that range from 0 to <paramref name="maxValue"/> – 1.
		///		However, if <paramref name="maxValue"/> is 0, the method returns 0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long NextInt64( this System.Random random, long maxValue ) => random.NextInt64( 0, maxValue );
		/// <summary>Returns a random long that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A 64-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextInt64(System.Random, long, long)"/> overload returns random integers that range from <paramref name="minValue"/> to <paramref name="maxValue"/> – 1.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		///		<para>Unlike the other overloads of the NextInt64 method, which return only non-negative values, this method can return a negative random integer.</para>
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long NextInt64( this System.Random random, long minValue, long maxValue ) {
			decimal range = Convert.ToDecimal( maxValue ) - Convert.ToDecimal( minValue );
			decimal value = Math.Truncate( range * Convert.ToDecimal( random.NextDouble() ) );
			return minValue + Convert.ToInt64( value );
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
		/// <summary>Returns a random single-precision floating-point number that is greater than or equal to 0f, and less 1f.</summary>
		/// <returns>
		///		A double-precision floating point number that is greater than or equal to 0f, and less than 1f.
		/// </returns>
		/// <remarks>
		///		<para>
		///			Due to rounding errors with floats, there is an EXTREMELY small chance that 1f will be selected.
		///			If this is a concern, please add checks in the client code.
		///		</para>	
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static float NextSingle( this System.Random random ) => random.NextSingle( float.MaxValue );
		/// <summary>Returns a random single-precision floating-point number that is greater than or equal to 0f, and less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0f.
		///	</param>
		/// <returns>
		///		A double-precision floating point number that is greater than or equal to 0f, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0f but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0f, 0f is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0f.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextDouble(System.Random, float)"/> overload returns random single-precision floating point numbers that range from 0f to <paramref name="maxValue"/>.
		///			However, if <paramref name="maxValue"/> is 0f, the method returns 0f.
		///		</para>
		///		<para>
		///			Due to rounding errors with floats, there is an EXTREMELY small chance that <paramref name="maxValue"/> will be selected.
		///			If this is a concern, please add checks in the client code.
		///		</para>	
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static float NextSingle( this System.Random random, float maxValue ) => random.NextSingle( 0, maxValue );
		/// <summary>Returns a random single-precision floating point number that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A single-precision floating point number greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextDouble(System.Random, float, float)"/> overload returns random single-precision floating-point that range from <paramref name="minValue"/> to <paramref name="maxValue"/>.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		///		<para>Unlike the other overloads of the NextDouble method, which return only non-negative values, this method can return a negative random single-precision floating point number.</para>
		///		<para>
		///			Due to rounding errors with floats, there is an EXTREMELY small chance that <paramref name="maxValue"/> will be selected.
		///			If this is a concern, please add checks in the client code.
		///		</para>	
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static float NextSingle( this System.Random random, float minValue, float maxValue ) =>
			// TODO: Make sure MaxValue cannot be returned
			Convert.ToSingle( random.NextDouble( minValue, maxValue ) );
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
		/// <summary>Returns a random unsigned short.</summary>
		/// <returns>A 16-bit unsigned integer that is greater than or equal to 0 and less than <see cref="System.UInt16.MaxValue"/>.</returns>
		/// <remarks>
		///		<see cref="Random.DataTypes.RandomDataTypes.NextUInt16(System.Random)"/> generates a random number whose value ranges from 0 to less than <see cref="System.UInt16.MaxValue"/>.
		///		To generate a random number whose value ranges from 0 to some other positive number, use the <see cref="Random.DataTypes.RandomDataTypes.NextUInt16(System.Random, ushort)"/> method overload.
		///		To generate a random number within a different range, use the <see cref="Random.DataTypes.RandomDataTypes.NextUInt16(System.Random, ushort, ushort)"/> method overload.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ushort NextUInt16( this System.Random random ) => random.NextUInt16( ushort.MaxValue );
		/// <summary>Returns a random unsigned short that is less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0.
		///	</param>
		/// <returns>
		///		A 16-bit unsigned integer that is greater than or equal to 0, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0, 0 is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextUInt16(System.Random, ushort)"/> overload returns random integers that range from 0 to <paramref name="maxValue"/> – 1.
		///		However, if <paramref name="maxValue"/> is 0, the method returns 0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ushort NextUInt16( this System.Random random, ushort MaxValue ) => random.NextUInt16( 0, MaxValue );
		/// <summary>Returns a random unsigned short that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A 16-bit unsigned integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextIntU16(System.Random, ushort, ushort)"/> overload returns random integers that range from <paramref name="minValue"/> to maxValue – 1.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ushort NextUInt16( this System.Random random, ushort MinValue, ushort MaxValue ) =>
			Convert.ToUInt16( random.Next( MinValue, MaxValue ) );
		#endregion

		#region uint
		/// <summary>Returns a non-negative random integer.</summary>
		/// <returns>A 32-bit unsigned integer that is greater than or equal to 0 and less than <see cref="System.UInt32.MaxValue"/>.</returns>
		/// <remarks>
		///		<see cref="Random.DataTypes.RandomDataTypes.NextUInt32(System.Random)"/> generates a random number whose value ranges from 0 to less than <see cref="System.UInt32.MaxValue"/>.
		///		To generate a random number whose value ranges from 0 to some other positive number, use the <see cref="Random.DataTypes.RandomDataTypes.NextUInt32(System.Random, uint)"/> method overload.
		///		To generate a random number within a different range, use the <see cref="Random.DataTypes.RandomDataTypes.NextUInt32(System.Random, uint, uint)"/> method overload.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static uint NextUInt32( this System.Random random ) => random.NextUInt32( uint.MaxValue );
		/// <summary>Returns a random unsigned integer that is less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0.</param>
		/// <returns>
		///		A 32-bit unsigned integer that is greater than or equal to 0, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0, 0 is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextUInt32(System.Random, uint)"/> overload returns random integers that range from 0 to <paramref name="maxValue"/> – 1.
		///		However, if <paramref name="maxValue"/> is 0, the method returns 0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static uint NextUInt32( this System.Random random, uint MaxValue ) => random.NextUInt32( 0, MaxValue );
		/// <summary>Returns a random unsigned integer that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A 32-bit unsigned integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextUInt32(System.Random, uint, uint)"/> overload returns random integers that range from <paramref name="minValue"/> to <paramref name="maxValue"/> – 1.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static uint NextUInt32( this System.Random random, uint MinValue, uint MaxValue ) =>
			Convert.ToUInt32( random.NextInt64( Convert.ToInt64( MinValue ), Convert.ToInt64( MaxValue ) ) );
		#endregion

		#region ulong
		/// <summary>Returns a random unsigned long.</summary>
		/// <returns>A 64-bit unsigned integer that is greater than or equal to 0 and less than <see cref="System.UInt64.MaxValue"/>.</returns>
		/// <remarks>
		///		<see cref="Random.DataTypes.RandomDataTypes.NextUInt64(System.Random)"/> generates a random number whose value ranges from 0 to less than <see cref="System.UInt64.MaxValue"/>.
		///		To generate a random number whose value ranges from 0 to some other positive number, use the <see cref="Random.DataTypes.RandomDataTypes.NextUInt64(System.Random, ulong)"/> method overload.
		///		To generate a random number within a different range, use the <see cref="Random.DataTypes.RandomDataTypes.NextUInt64(System.Random, ulong, ulong)"/> method overload.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ulong NextUInt64( this System.Random random ) => random.NextUInt64( ulong.MaxValue );
		/// <summary>Returns a random unsigned long that is less than the specified maximum.</summary>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number to be generated.
		///		<paramref name="maxValue"/> must be greater than or equal to 0.</param>
		/// <returns>
		///		A 64-bit unsigned integer that is greater than or equal to 0, and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue"/>.
		///		However, if <paramref name="maxValue"/> equals 0, 0 is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
		/// <remarks>
		///		The <see cref="Random.DataTypes.RandomDataTypes.NextUInt64(System.Random, ulong)"/> overload returns random integers that range from 0 to <paramref name="maxValue"/> – 1.
		///		However, if <paramref name="maxValue"/> is 0, the method returns 0.
		/// </remarks>
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static ulong NextUInt64( this System.Random random, ulong MaxValue ) => random.NextUInt64( 0, MaxValue );
		/// <summary>Returns a random unsigned long that is within a specified range.</summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned.
		///		<paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.
		///	</param>
		/// <returns>
		///		A 64-bit unsigned integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/> but not <paramref name="maxValue"/>.
		///		If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
		/// </returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
		/// <remarks>
		///		<para>
		///			The <see cref="Random.DataTypes.RandomDataTypes.NextUInt64(System.Random, ulong, ulong)"/> overload returns random integers that range from <paramref name="minValue"/> to <paramref name="maxValue"/> – 1.
		///			However, if <paramref name="maxValue"/> equals <paramref name="minValue"/>, the method returns <paramref name="minValue"/>.
		///		</para>
		/// </remarks>
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
