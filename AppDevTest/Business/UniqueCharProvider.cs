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
            
            if (str == null)
            {
                return (-1);
            }

            Dictionary<char, int> strCharacters = new Dictionary<char, int>();

            // Loop through sting and add each character to a dictionary.
            // Key is the character, Value is the index.
            int curIndex = 0;
			foreach(char curChar in str)
            {   
                // If the character is already in the dictionary then set value to -1.
                if (strCharacters.ContainsKey(curChar))
                {
                    strCharacters[curChar] = -1;
                }
                else
                {
                    strCharacters[curChar] = curIndex;
                }

                curIndex++;
            }

            // Loop through the original string and whichever value is not -1 is the first unique character.
            foreach(char dictChar in str)
            {
                if (strCharacters[dictChar] != -1)
                {
                    return (strCharacters[dictChar]);
                }
            }


            return (-1);
		}

	}
}