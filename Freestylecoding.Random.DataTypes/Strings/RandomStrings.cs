using System;
using System.Collections.Generic;
using System.Linq;

namespace Freestylecoding.Random.DataTypes.Strings {
	public static class RandomStrings {
		private static char RandomDistributedFirstLetter( System.Random random ) {
			double val = random.NextDouble();
			if( val < 0.1163534228 ) return 'a';
			else if( val < 0.1605163295 ) return 'b';
			else if( val < 0.2126871246 ) return 'c';
			else if( val < 0.2443003556 ) return 'd';
			else if( val < 0.2721785640 ) return 'e';
			else if( val < 0.3122877262 ) return 'f';
			else if( val < 0.3286421450 ) return 'g';
			else if( val < 0.3704743977 ) return 'h';
			else if( val < 0.4431230765 ) return 'i';
			else if( val < 0.4482126672 ) return 'j';
			else if( val < 0.4567384787 ) return 'k';
			else if( val < 0.4807920240 ) return 'l';
			else if( val < 0.5188992142 ) return 'm';
			else if( val < 0.5416479916 ) return 'n';
			else if( val < 0.6176532106 ) return 'o';
			else if( val < 0.6606707105 ) return 'p';
			else if( val < 0.6628818438 ) return 'q';
			else if( val < 0.6910289738 ) return 'r';
			else if( val < 0.7576219360 ) return 's';
			else if( val < 0.9167637773 ) return 't';
			else if( val < 0.9285465284 ) return 'u';
			else if( val < 0.9367536180 ) return 'v';
			else if( val < 0.9915040687 ) return 'w';
			else if( val < 0.9919522714 ) return 'x';
			else if( val < 0.9995517973 ) return 'y';
			else return 'z';
		}

		private static char RandomDistributedLetter( System.Random random ) {
			double val = random.NextDouble();
			if( val < 0.0837768579 ) return 'a';
			else if( val < 0.0984624483 ) return 'b';
			else if( val < 0.1201458703 ) return 'c';
			else if( val < 0.1620342992 ) return 'd';
			else if( val < 0.2720283856 ) return 'e';
			else if( val < 0.2940074906 ) return 'f';
			else if( val < 0.3139168145 ) return 'g';
			else if( val < 0.3739404692 ) return 'h';
			else if( val < 0.4483540311 ) return 'i';
			else if( val < 0.4498324463 ) return 'j';
			else if( val < 0.4625468165 ) return 'k';
			else if( val < 0.5022669032 ) return 'l';
			else if( val < 0.5260201064 ) return 'm';
			else if( val < 0.5925487877 ) return 'n';
			else if( val < 0.6665681057 ) return 'o';
			else if( val < 0.6855903804 ) return 'p';
			else if( val < 0.6865759905 ) return 'q';
			else if( val < 0.7613837966 ) return 'r';
			else if( val < 0.8237729154 ) return 's';
			else if( val < 0.9160260201 ) return 't';
			else if( val < 0.9432288587 ) return 'u';
			else if( val < 0.9528878376 ) return 'v';
			else if( val < 0.9781194559 ) return 'w';
			else if( val < 0.9795978711 ) return 'x';
			else if( val < 0.9992115119 ) return 'y';
			else return 'z';
		}

		private static int RandomSentenceLength( System.Random random ) {
			double val = random.NextDouble();
			if( val < 0.0075757576 ) return 1;
			else if( val < 0.0227272727 ) return 2;
			else if( val < 0.0454545455 ) return 3;
			else if( val < 0.0757575758 ) return 4;
			else if( val < 0.1136363636 ) return 5;
			else if( val < 0.1590909091 ) return 6;
			else if( val < 0.2083333333 ) return 7;
			else if( val < 0.2613636364 ) return 8;
			else if( val < 0.3181818182 ) return 9;
			else if( val < 0.3787878788 ) return 10;
			else if( val < 0.4431818182 ) return 11;
			else if( val < 0.5113636364 ) return 12;
			else if( val < 0.5833333333 ) return 13;
			else if( val < 0.6590909091 ) return 14;
			else if( val < 0.7272727273 ) return 15;
			else if( val < 0.7878787879 ) return 16;
			else if( val < 0.8409090909 ) return 17;
			else if( val < 0.8863636364 ) return 18;
			else if( val < 0.9242424242 ) return 19;
			else if( val < 0.9545454545 ) return 20;
			else if( val < 0.9772727273 ) return 21;
			else if( val < 0.9924242424 ) return 22;
			else return 23;
		}
		private static int RandomParagraphLength( System.Random random ) {
			int length;
			double val = random.NextDouble();
			if( val < 0.0625000000 ) length = 2;
			else if( val < 0.1875000000 ) length = 3;
			else if( val < 0.3750000000 ) length = 4;
			else if( val < 0.6250000000 ) length = 5;
			else if( val < 0.8125000000 ) length = 6;
			else if( val < 0.9375000000 ) length = 7;
			else length = 8;

			return length;
		}

		public static string NextWord( this System.Random random ) {
			int length;
			double val = random.NextDouble();
			if( val < 0.0350877193 ) length = 1;
			else if( val < 0.1052631579 ) length = 2;
			else if( val < 0.2105263158 ) length = 3;
			else if( val < 0.3508771930 ) length = 4;
			else if( val < 0.5263157895 ) length = 5;
			else if( val < 0.6666666667 ) length = 6;
			else if( val < 0.7719298246 ) length = 7;
			else if( val < 0.8421052632 ) length = 8;
			else if( val < 0.8736842105 ) length = 9;
			else if( val < 0.9017543860 ) length = 10;
			else if( val < 0.9263157895 ) length = 11;
			else if( val < 0.9473684211 ) length = 12;
			else if( val < 0.9649122807 ) length = 13;
			else if( val < 0.9789473684 ) length = 14;
			else if( val < 0.9894736842 ) length = 15;
			else if( val < 0.9964912281 ) length = 16;
			else length = 17;


			string word = random.NextWord( length );
			return random.NextDouble() < 0.005
				? word.Insert( Math.Max( 0, word.Length - 1 ), "'" )
				: word;
		}

		public static string NextWord( this System.Random random, int length ) =>
			new string(
				new[] { RandomDistributedFirstLetter( random ) }
					.Concat(
						Enumerable
							.Range( 0, length - 1 )
							.Select( i => RandomDistributedLetter( random ) )
					)
					.ToArray()
			);

		public static string NextSentence( this System.Random random ) {
			string sentence = random.NextSentence( RandomSentenceLength( random ) );
			if( new[] { '"', '(' }.Contains( sentence.First() ) ) return sentence;
			if( new[] { '"', ')' }.Contains( sentence.Last() ) ) return sentence;

			double val = random.NextDouble();
			if( val < 0.001 )
				return $"{sentence.TrimEnd( '.', '?', '!' )}; {random.NextSentence( RandomSentenceLength( random ) ).Substring( 1 ).Trim()}";
			else if( val < 0.03 )
				return $"{sentence.TrimEnd( '.', '?', '!' )}, {random.NextSentence( RandomSentenceLength( random ) ).Substring( 1 ).Trim()}";
			else
				return sentence;
		}

		public static string NextSentence( this System.Random random, int length ) {
			char terminator = '.';
			double termChance = random.NextDouble();
			if( termChance < 0.01 )
				terminator = '!';
			else if( termChance < 0.05 )
				terminator = '?';

			string[] words =
				Enumerable
					.Range( 0, length )
					.Select( i => random.NextWord() )
					.ToArray();

			words[0] = new string(
				new[] { char.ToUpper( words[0][0] ) }
					.Concat( words[0].Skip( 1 ) )
					.ToArray()
			);
			words[words.Length - 1] += terminator;

			double delimiterChance = random.NextDouble();
			if( delimiterChance < 0.2 ) {
				int start = random.Next( 0, length - 1 );
				int end = random.Next( start + 1, length );

				if( 1 == length ) {
					start = end = 0;
				} else {
					start = random.Next( 0, length - 1 );
					end = random.Next( start + 1, length );
				}

				if( delimiterChance < 0.05 ) {
					words[start] = "(" + words[start];
					words[end] += ")";
				} else {
					words[start] = "\"" + words[start];
					words[end] += "\"";
				}
			}

			return string.Join( " ", words );
		}

		public static string NextParagraph( this System.Random random ) =>
			random.NextParagraph( RandomParagraphLength( random ) );

		public static string NextParagraph( this System.Random random, int length ) =>
			string.Join( " ", Enumerable.Range( 0, length ).Select( i => random.NextSentence() ) );

		public static string NextBlobText( this System.Random random, int MinLength, int MaxLength ) {
			int TargetLength = random.Next( MinLength, MaxLength );

			List<string> lines = new List<string>();
			while( TargetLength > lines.Sum( s => s.Length ) )
				lines.Add( random.NextSentence() );

			while( MaxLength < lines.Sum( s => s.Length ) ) {
				string lastLine = lines.Last()
					.Replace( ",", "" )
					.Replace( ";", "" )
					.Replace( "(", "" )
					.Replace( ")", "" )
					.Replace( "\"", "" );

				char lastChar = lastLine.Last();
				
				lastLine = string.Join(
					" ",
					lastLine
						.Split( ' ' )
						.Reverse()
						.Skip( 1 )
						.Reverse()
				);

				if( string.IsNullOrWhiteSpace( lastLine ) )
					lines.RemoveAt( lines.Count - 1 );
				else
					lines[lines.Count - 1] = $"{lastLine}{lastChar}";
			}

			int Position = RandomParagraphLength( random );
			while( Position < lines.Count ) {
				lines[Position] = $"{lines[Position]}{Environment.NewLine}";
				Position += RandomParagraphLength( random );
			}

			return string.Join(
				"",
				lines.Select( s => s.EndsWith( Environment.NewLine ) ? s : $"{s} " )
			);
		}
	}
}
