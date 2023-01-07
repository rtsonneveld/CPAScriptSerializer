using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer {
   public static class Util {


      /// <summary>
      /// Function that splits a list of values separated by some separator, but ignores the separator within quotes
      /// </summary>
      /// <param name="line">The input string</param>
      /// <param name="separator">The separator to use</param>
      /// <param name="quoteCharacter">The quote character to use</param>
      /// <returns>Array of the elements in the string, separated by the separator</returns>
      public static string[] SplitSeparatedValues(this string line, char separator, char quoteCharacter)
      {
         bool currentArgumentUsesQuotes = false;

         List<string> result = new List<string>();
         StringBuilder currentStr = new StringBuilder("");
         bool inQuotes = false;
         for (int i = 0; i < line.Length; i++) // For each character
         {
            if (line[i] == quoteCharacter) {
               // Quotes are closing or opening
               inQuotes = !inQuotes;
               if (!currentArgumentUsesQuotes) {
                  currentStr.Clear();
                  currentArgumentUsesQuotes = true;
               }
            }

            else if (line[i] == separator) // Encountered the separator
            {
               if (!inQuotes) // If not in quotes, end of current string, add it to result
               {
                  result.Add(currentStr.ToString());
                  currentArgumentUsesQuotes = false;
                  currentStr.Clear();
               } else
                  currentStr.Append(line[i]); // If in quotes, just add it 
            } else {
               // Add any other character to current string
               if (!string.IsNullOrWhiteSpace(line[i].ToString()) || inQuotes) {
                  currentStr.Append(line[i]);
               }
            }
         }
         result.Add(currentStr.ToString());
         return result.ToArray(); // Return array of all strings
      }
   }
}
