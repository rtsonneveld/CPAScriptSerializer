using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI;
using CPAScriptSerializer.Modules.AI.Commands.DEC.Variables;
using CPAScriptSerializer.Modules.GLI;
using CPAScriptSerializer.Modules.GMT;
using CPAScriptSerializer.Modules.IPT;
using CPAScriptSerializer.Modules.MEC;
using CPAScriptSerializer.Modules.SND;
using CPAScriptSerializer.Modules.SPO;
using CPAScriptSerializer.Tests;
using Newtonsoft.Json;

namespace CPAScriptSerializer
{
   class Program
   {
      private const string TestFilesDir = @"..\..\..\TestGameData\GAMEDATA\";
      private const string TestFilesOutputDir = @"..\..\..\TestGameDataOutput\GAMEDATA\";

      public static readonly Encoding FileEncoding = Encoding.GetEncoding("ISO-8859-1");

      static void Main(string[] args)
      {
         System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

         List<CPAScript> scripts = new List<CPAScript>();

         bool readAndWrite = true;
         bool compare = false;
         if (readAndWrite) {
            foreach (var file in Directory.GetFiles(Path.Combine(TestFilesDir), "*.*", SearchOption.AllDirectories)) {

               var script = ReadAndWriteTest(file);
               if (script != null)
                  scripts.Add(script);
            }
         }

         //File.Delete("gamedata.json");
         //File.WriteAllText($"gamedata.json", JsonConvert.SerializeObject(scripts));

         if (compare) {

            var compareFlags = EnumComparisonFlags.IgnoreCase | EnumComparisonFlags.IgnoreDoubleQuotes |
                               EnumComparisonFlags.IgnoreEmptyLines | EnumComparisonFlags.IgnoreSingleQuotes |
                               EnumComparisonFlags.IgnoreEmptyBracketPairs | EnumComparisonFlags.IgnoreSpaces |
                               EnumComparisonFlags.IgnoreTabs | EnumComparisonFlags.RoundNumbers |
                               EnumComparisonFlags.IgnoreColonAtEnd;

            Dictionary<(string original, string test), ComparisonResult> comparisonResults =
               new Dictionary<(string, string), ComparisonResult>();

            Debug.WriteLine($"Comparing files");

            foreach (var file in Directory.GetFiles(Path.Combine(TestFilesDir), "*.*", SearchOption.AllDirectories)) {
               if (!CPAScript.ExtensionToTypeMap.ContainsKey(Path.GetExtension(file).ToLower().Substring(1))) continue;

               Debug.WriteLine($"Comparing file {file}");

               var outputFile = Path.Combine(TestFilesOutputDir, Path.GetRelativePath(TestFilesDir, file));
               FileCompareTest test = new FileCompareTest(file, outputFile);
               comparisonResults.Add((file, outputFile), test.Compare(compareFlags, FileEncoding));
            }

            Debug.WriteLine($"Finished Comparing");

            List<string> results = new List<string>();

            foreach (var fileAndResult in comparisonResults) {
               if (fileAndResult.Value.Flags != EnumComparisonResult.FilesMatch) {
                  results.Add(
                     $"File file://{Path.GetFullPath(fileAndResult.Key.original)} doesn't match with file://{Path.GetFullPath(fileAndResult.Key.test)}: {fileAndResult.Value.Flags.ToString()}");
                  foreach (var diff in fileAndResult.Value.DifferingLines) {
                     results.Add($"Mismatch at line {diff.Key}:");
                     results.Add($"ORG: {diff.Value.original}");
                     results.Add($"TST: {diff.Value.test}");
                  }
               }
            }

            const string compareResultsFilename = "comparison_results.txt";
            if (File.Exists(compareResultsFilename)) {
               File.Delete(compareResultsFilename);
            }

            File.WriteAllLines(compareResultsFilename, results);
         }

         //Debug.WriteLine("Finished");
      }

      private static CPAScript ReadAndWriteTest(string path)
      {
         string relativePath = Path.GetRelativePath(TestFilesDir, path);

         string outputPath = Path.Combine(TestFilesOutputDir, relativePath);

         try {
            CPAScript script = CPAScript.ReadFile(path, FileEncoding); // new T();

            // Ensure directory exists
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));

            if (File.Exists(outputPath)) {
               File.Delete(outputPath);
            }

            script.Write(File.OpenWrite(outputPath), FileEncoding);

            Debug.WriteLine($"input path: {path}, output path: {outputPath}");

            return script;
         } catch (NotSupportedException e) {
            Debug.WriteLine(e.Message);
         }

         return null;
      }
   }
}