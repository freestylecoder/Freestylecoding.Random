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
			if( val < 0.0075757576 ) return 1;			// 0.76%
			else if( val < 0.0227272727 ) return 2;		// 1.52%
			else if( val < 0.0454545455 ) return 3;		// 2.27%
			else if( val < 0.0757575758 ) return 4;		// 3.03%
			else if( val < 0.1136363636 ) return 5;		// 3.79%
			else if( val < 0.1590909091 ) return 6;		// 4.55%
			else if( val < 0.2083333333 ) return 7;		// 4.92%
			else if( val < 0.2613636364 ) return 8;		// 5.30%
			else if( val < 0.3181818182 ) return 9;		// 5.68%
			else if( val < 0.3787878788 ) return 10;	// 6.06%
			else if( val < 0.4431818182 ) return 11;	// 6.44%
			else if( val < 0.5113636364 ) return 12;	// 6.82%
			else if( val < 0.5833333333 ) return 13;	// 7.20%
			else if( val < 0.6590909091 ) return 14;	// 7.58%
			else if( val < 0.7272727273 ) return 15;	// 6.82%
			else if( val < 0.7878787879 ) return 16;	// 6.06%
			else if( val < 0.8409090909 ) return 17;	// 5.30%
			else if( val < 0.8863636364 ) return 18;	// 4.55%
			else if( val < 0.9242424242 ) return 19;	// 3.79%
			else if( val < 0.9545454545 ) return 20;	// 3.03%
			else if( val < 0.9772727273 ) return 21;	// 2.27%
			else if( val < 0.9924242424 ) return 22;	// 1.52%
			else return 23;								// 0.76%
		}
		private static int RandomParagraphLength( System.Random random ) {
			int length;
			double val = random.NextDouble();
			if( val < 0.0625000000 ) length = 2;		//  6.25%
			else if( val < 0.1875000000 ) length = 3;	// 12.50%
			else if( val < 0.3750000000 ) length = 4;	// 18.75%
			else if( val < 0.6250000000 ) length = 5;	// 25.00%
			else if( val < 0.8125000000 ) length = 6;	// 18.75%
			else if( val < 0.9375000000 ) length = 7;	// 12.50%
			else length = 8;							//  6.25%

			return length;
		}

		/// <summary>Returns a random string between 1 and 18 charachers long.</summary>
		/// <returns>A string that has a length greater than or equal to 1 and less than 19.</returns>
		/// <remarks>
		///		<para>
		///			<see cref="Random.DataTypes.Strings.RandomStrings.NextWord(System.Random)"/> generates a random string whose length ranges from 1 to less than 18 characters.
		///			To specify the length of the word, please use <see cref="Random.DataTypes.Strings.RandomStrings.NextWord(System.Random, int)"/>.
		///		</para>
		///		<para>
		///			The word that is returned only uses the lowercase letter a - z.
		///		</para>
		///		<para>
		///			The length of the string is determined by characteristics of the English language.
		///			That is to say, 5 letter word are more likely than an other.
		///			Shorter words are more likely than longer words.
		///			The exact percentages used for the distribution were based on two factors.
		///			The first factor was that the average length of an English word is a little under 5 characters.
		///			The second factor was based on personal observation and intuition.
		///		</para>
		///		<para>
		///			The individual character distribution is based on the following Wikipedia article:
		///			<seealso cref="https://en.wikipedia.org/wiki/Letter_frequency"/>.
		///			Note that this references a different distribution for the first letter of a word than the subsequent letters.
		///			This factor was taken into consideration.
		///		</para>
		///		<para>
		///			There is a small chance that an apostrophe will be added to your word.
		///			It will always be the next to last letter.
		///			This include the case of one letter words, in which it will be the first character.
		///		</para>
		/// </remarks>
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

		/// <summary>Returns a random string of the specified length.</summary>
		/// <param name="length">The length of the random string to return.</param>
		/// <returns>A random string that has a length equal to <paramref name="length"/>.</returns>
		/// <exception cref="System.ArgumentOutOfRangeException"><paramref name="length"/> is less than 0.</exception>
		/// <remarks>
		///		<para>
		///			The word that is returned only uses the lowercase letter a - z.
		///		</para>
		///		<para>
		///			The individual character distribution is based on the following Wikipedia article:
		///			<seealso cref="https://en.wikipedia.org/wiki/Letter_frequency"/>.
		///			Note that this references a different distribution for the first letter of a word than the subsequent letters.
		///			This factor was taken into consideration.
		///		</para>
		/// </remarks>
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

		/// <summary>Returns a random string of random words that is structured to look like a sentence.</summary>
		/// <returns>A random string that is structured to look like a sentence.</returns>
		/// <remarks>
		///		<para>
		///			<see cref="Random.DataTypes.Strings.RandomStrings.NextSentence(System.Random)"/> generates a random string with an unspecified length.
		///			The theoretical lower bound for the length of the returned string is 2 characters.
		///			The theoretical upper bound for the length of the returned string is 875 characters.
		///			To specify the number of words in the sentence, please use <see cref="Random.DataTypes.Strings.RandomStrings.NextSentnce(System.Random, int)"/>.
		///		</para>
		///		<para>
		///			The sentence is generated using calls to <see cref="Random.DataTypes.Strings.RandomStrings.NextWord(System.Random)"/>.
		///		</para>
		///		<para>
		///			The length of the string is determined by characteristics of the English language.
		///			That is to say, 14 word sentences are more likely than any other.
		///			Shorter sentences are more likely than longer sentences.
		///			The exact percentages used for the distribution were based on two factors.
		///			The first factor was that the average length of an English sentence is a little over 14 words.
		///			The second factor was based on personal observation and intuition.
		///		</para>
		///		<para>
		///			The sentence is generated by choosing a length and internally calling <see cref="Random.DataTypes.Strings.RandomStrings.NextSentence(System.Random, int)"/>.
		///			Please refer to the documention to see how things such as quotes and punctuation are used.
		///		</para>
		///		<para>
		///			There is a small chance of generating a compound sentence.
		///			This compound sentence with either be delimited by a comma or a semicolon.
		///		</para>
		/// </remarks>
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

		/// <summary>Returns a random string of random words that is structured to look like a sentence.</summary>
		/// <param name="length">The number of words to put in the sentence.</param>
		/// <returns>A random string that is structured to look like a sentence.</returns>
		/// <remarks>
		///		<para>
		///			<see cref="Random.DataTypes.Strings.RandomStrings.NextSentence(System.Random, int)"/> generates a random string that is constructed to look like an English sentence using the number of words that is specified in <paramref name="length"/>.
		///			The theoretical lower bound for the length of the returned string is ( 2 * <paramref name="length"/> ) characters.
		///			The theoretical upper bound for the length of the returned string is ( ( <paramref name="length"/> * 19 ) + 2 ) characters.
		///		</para>
		///		<para>
		///			The sentence is generated using calls to <see cref="Random.DataTypes.Strings.RandomStrings.NextWord(System.Random)"/>.
		///		</para>
		///		<para>
		///			By default, all sentences will start with a capital letter and end with a period.
		///			There is a small chance that the generated sentence will end with either a question mark or an exclamation mark.
		///			Furthermore, there is a small chance some or all of the returned sentence will be incased in either double quotation marks or parenthesis.
		///		</para>
		/// </remarks>
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

		/// <summary>Returns a random string of random sentences of random words that is structured to look like a paragragh.</summary>
		/// <returns>A random string that is structured to look like a paragraph.</returns>
		/// <remarks>
		///		<para>
		///			<see cref="Random.DataTypes.Strings.RandomStrings.NextParagraph(System.Random)"/> generates a random string with an unspecified length.
		///			The theoretical lower bound for the length of the returned string is 5 characters.
		///			The theoretical upper bound for the length of the returned string is 7007 characters.
		///			To specify the number of sentences in the paragraph, please use <see cref="Random.DataTypes.Strings.RandomStrings.NextParagraph(System.Random, int)"/>.
		///		</para>
		///		<para>
		///			The paragraph is generated by choosing a length and internally calling <see cref="Random.DataTypes.Strings.RandomStrings.NextParagraph(System.Random, int)"/>.
		///		</para>
		///		<para>
		///			The length of the string is determined by characteristics of the English language.
		///			That is to say, 5 sentence paragraphs are more likely than any other.
		///			The exact percentages used for the distribution were based on two factors.
		///			The first factor was that the average length of an English paragraph is a about 5 sentences.
		///			The second factor was using linear scaling.
		///		</para>
		/// </remarks>
		public static string NextParagraph( this System.Random random ) =>
			random.NextParagraph( RandomParagraphLength( random ) );

		/// <summary>Returns a random string of random sentences of random words that is structured to look like a paragragh.</summary>
		/// <param name="length">The number of sentences to put in the paragraph.</param>
		/// <returns>A random string that is structured to look like a paragraph.</returns>
		/// <remarks>
		///		<para>
		///			<see cref="Random.DataTypes.Strings.RandomStrings.NextParagraph(System.Random, int)"/> generates a random string that is constructed to look like an English paragraph using the number of sentences that is specified in <paramref name="length"/>.
		///			The theoretical lower bound for the length of the returned string is ( ( 3 * <paramref name="length"/> ) - 1 ) characters.
		///			The theoretical upper bound for the length of the returned string is ( ( 876 * <paramref name="length"/> ) - 1 ) characters.
		///		</para>
		///		<para>
		///			The paragraph is generated using calls to <see cref="Random.DataTypes.Strings.RandomStrings.NextSentence(System.Random)"/>.
		///		</para>
		/// </remarks>
		public static string NextParagraph( this System.Random random, int length ) =>
			string.Join( " ", Enumerable.Range( 0, length ).Select( i => random.NextSentence() ) );

		/// <summary>Returns a random string that is structured to look like natural text.</summary>
		/// <param name="minLength">
		///		The suggested inclusive minimum length of the text.
		///		Please see remarks for circumstances in with <paramref name="minLength"/> may be ignored.
		///	</param>
		/// <param name="maxLength">The exclusive maximum length of the text.</param>
		/// <returns>A random string that is structured to look like natural text.</returns>
		/// <remarks>
		///		<para>
		///			<see cref="Random.DataTypes.Strings.RandomStrings.NextBlobText(System.Random, int, int)"/> generates a random string that is constructed to look like a block of English text that is less that <paramref name="maxLength"/> charactes long.
		///			The returned value will usually be longer than <paramref name="minLength"/>, but this is not guaranteed.
		///		</para>
		///		<para>
		///			The text is generated by first choosing a random length between <paramref name="minLength"/> and <paramref name="maxLength"/>.
		///			Then, successive calls to <see cref="Random.DataTypes.Strings.RandomStrings.NextSentence(System.Random)"> are used create a list of sentences that is longer that the generated length.
		///			If the produced list of strings is longer than <paramref name="maxLength"/>, words are removed from end of the text until the total is within bounds.
		///			Once the string is shorter that <paramref name="maxLength"/>, <see cref="System.Environment.NewLine"/>s are randomly added to create paragraphs.
		///		</para>
		///		<para>
		///			Due to the algorithm mentioned above, it is possible for the produces string to be shorter than <paramref name="minLength"/>.
		///			This typically will only happen if <paramref name="minLength"/> and <paramref name="maxLength"/> are very close in value.
		///		</para>
		/// </remarks>
		public static string NextBlobText( this System.Random random, int minLength, int maxLength ) {
			int TargetLength = random.Next( minLength, maxLength );

			List<string> lines = new List<string>();
			while( TargetLength > lines.Sum( s => s.Length ) )
				lines.Add( random.NextSentence() );

			while( maxLength <= lines.Sum( s => s.Length ) ) {
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
