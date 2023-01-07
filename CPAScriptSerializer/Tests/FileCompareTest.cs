using CPAScriptSerializer.Modules.GMT.Commands.Material;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CPAScriptSerializer.Tests {
   public class FileCompareTest
   {
      public string PathFileOriginal;
      public string PathFileTest;

      public FileCompareTest(string pathFileOriginal, string pathFileTest)
      {
         this.PathFileOriginal = pathFileOriginal;
         this.PathFileTest = pathFileTest;
      }

      public ComparisonResult Compare(EnumComparisonFlags flags, Encoding encoding)
      {
         var originalLines = FilterLines(File.ReadAllLines(PathFileOriginal, encoding), flags);
         var testLines = FilterLines(File.ReadAllLines(PathFileTest, encoding), flags);

         ComparisonResult result = new ComparisonResult();

         var resultFlags = EnumComparisonResult.FilesMatch;

         if (originalLines.Length != testLines.Length) {
            resultFlags |= EnumComparisonResult.LineCountDoesntMatch;
         }

         for (var i = 0; i < originalLines.Length; i++) {
            var line = originalLines[i];
            if (i >= testLines.Length) {
               continue;
            }

            string testLine = testLines[i];

            if (!line.Equals(testLine)) {
               resultFlags |= EnumComparisonResult.LineContentDoesntMatch;
               result.DifferingLines.Add(i, (line, testLine));
            }
         }

         result.Flags = resultFlags;

         return result;
      }

      private readonly string[] IgnoredLineStarts = new string[]
      {
         "letter(",
         "addref(",
         "{iptlink",
         "addvertex(",
         "specularcolor(",
         "ambientcolor(",
         "diffusecolor(",
         "backgroundcolor(",
         "color(",
      };

      private string[] FilterLines(string[] lines, EnumComparisonFlags flags)
      {
         List<string> filteredLines = new List<string>();

         foreach (var l in lines) {

            string line = l;

            foreach (var s in IgnoredLineStarts) {
               if (line.Trim().Replace(" ", "").ToLower().StartsWith(s)) {
                  line = "IGNORE"; // Ignore this line
               }
            }

            if (flags.HasFlag(EnumComparisonFlags.IgnoreCase)) {
               line = line.ToLower();
            }
            if (flags.HasFlag(EnumComparisonFlags.IgnoreDoubleQuotes)) {
               line = line.Replace("\"", "");
            }
            if (flags.HasFlag(EnumComparisonFlags.IgnoreSingleQuotes)) {
               line = line.Replace("'", "");
            }
            if (flags.HasFlag(EnumComparisonFlags.IgnoreEmptyBracketPairs)) {
               line = line.Replace("()", "");
            }
            if (flags.HasFlag(EnumComparisonFlags.IgnoreColonAtEnd)) {

               line = line.TrimEnd();

               if (line.EndsWith(":")) {
                  line = line.Substring(0,line.Length-1);
               }
            }
            if (flags.HasFlag(EnumComparisonFlags.RoundNumbers)) {

               line = Regex.Replace(line, "[+-]?([0-9]*)?\\.[0-9]+", (match) =>
               {
                  float number = float.Parse(match.Value);
                  return ((int)number).ToString();
               });
            }
            if (flags.HasFlag(EnumComparisonFlags.IgnoreSpaces)) {
               line = line.Replace(" ", "");
            }
            if (flags.HasFlag(EnumComparisonFlags.IgnoreTabs)) {
               line = line.Replace("\t", "");
            }

            if (!flags.HasFlag(EnumComparisonFlags.IgnoreEmptyLines) || !string.IsNullOrWhiteSpace(line)) {
               filteredLines.Add(line);
            }
         }

         return filteredLines.ToArray();
      }
   }
}
