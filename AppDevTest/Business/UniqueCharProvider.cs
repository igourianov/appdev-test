using System;
using System.Collections.Generic;

namespace AppDevTest.Business
{
	public class UniqueCharProvider
	{
		/// <summary>
		/// Returns index of the first non-repeating character from the given string
		/// </summary>
		/// <param name="str">String to search for non-repeating characters</param>
		/// <returns>Index of the first non-repeating character. Returns -1 if not found.</returns>
		public int FindFirst(string str)
		{
            // Setup dict of each char count (O(n^2) worst case (depending on how dicts are implemented))
            IDictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char curr in str) {
                int result;
                if (dict.TryGetValue(curr, out result))
                {
                    dict[curr] = result + 1;
                }
                else {
                    dict.Add(curr, 1);
                }
            }
            // Iterate over the string, find the first char that's only found once
            for (int i = 0; i < str.Length; i++) {
                char curr = str[i];
                if (dict[curr] == 1) {
                    return i;
                }
            }
            return -1;
		}
	}
}