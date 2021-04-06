using System;
using System.Collections.Generic;

namespace Core.StringManipulation.StringSplit
{
    public static class StringSplitExtensions
    {
        public static string[] Split(this string word, char separator)
        {
            return word.SplitWord(separator, StringSplitOptions.Default);
        }

		public static string[] SplitWord(this string word, char separator, StringSplitOptions options = null)
		{
			if (word.Length == 0)
				return new string[] { "" };


			options = options ?? StringSplitOptions.Default;

			List<string> splitWords = new List<string>();

			int lastCharacter = word.Length - 1;
			int firstCharacter = 0;

			int start = options.Reverse ? lastCharacter : firstCharacter;
			int finish = options.Reverse ? firstCharacter : lastCharacter;
			int step = options.Reverse ? -1 : 1;

			int splitBeginning = start;
			int i = start;

			while (i != finish + step && (options.Count <= 0 || splitWords.Count < options.Count - 1))
            {
				if (word[i] == separator)
				{
					splitWords.Add(word.Substring(options.Reverse ? i + 1 : splitBeginning, Math.Abs(i - splitBeginning)));
					splitBeginning = i + step;
				}
				i += step;
            }


			splitWords.Add(word.Substring(options.Reverse ? finish : splitBeginning, Math.Abs(finish - splitBeginning + step)));

			return splitWords.ToArray();

		}
	}
}
