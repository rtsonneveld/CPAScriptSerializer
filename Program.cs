using System;
using System.Diagnostics;
using System.IO;
using CPAScriptSerializer.Modules.AI;
using CPAScriptSerializer.Modules.GLI;
using CPAScriptSerializer.Modules.IPT;
using CPAScriptSerializer.Modules.SND;
using CPAScriptSerializer.Modules.SPO;

namespace CPAScriptSerializer
{
   class Program
   {
      private const string TestFilesDir = @"..\..\..\TestFiles\";

      static void Main(string[] args)
      {
         /*ReadAndWriteTest<CPAScript_LCB>(Path.Combine(TestFilesDir, "SND","Rayman2.lcb"));
         ReadAndWriteTest<CPAScript_CSB>(Path.Combine(TestFilesDir, "SND", "nature.csb"));*/
         //ReadAndWriteTest<CPAScript_SPO>(Path.Combine(TestFilesDir, "Gymg", "Gymg.spo"));
         ReadAndWriteTest<CPAScript_MOD>(Path.Combine(TestFilesDir, "Gymg", "Gymg.mod"));

         foreach (var file in Directory.GetFiles(Path.Combine(TestFilesDir, "IPT"))) {
            //ReadAndWriteTest<CPAScript_IPT>(file);
         }

         //Debug.WriteLine("Finished");
      }

      private static void ReadAndWriteTest<T>(string path) where T: CPAScript, new()
      {
         const string OutputPostfix = "_output";
         
         if (Path.GetFileNameWithoutExtension(path).EndsWith(OutputPostfix)) {
            return;
         }
         string outputPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + OutputPostfix +
                             Path.GetExtension(path));

         CPAScript script = new T();
         script.Read(File.OpenRead(path));
         File.Delete(outputPath);
         script.Write(File.OpenWrite(outputPath));
      }
   }
}