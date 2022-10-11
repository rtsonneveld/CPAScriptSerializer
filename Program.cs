using System;
using System.Diagnostics;
using System.IO;
using CPAScriptSerializer.Modules.AI;
using CPAScriptSerializer.Modules.GLI;
using CPAScriptSerializer.Modules.GMT;
using CPAScriptSerializer.Modules.IPT;
using CPAScriptSerializer.Modules.MEC;
using CPAScriptSerializer.Modules.SND;
using CPAScriptSerializer.Modules.SPO;

namespace CPAScriptSerializer
{
   class Program
   {
      private const string TestFilesDir = @"..\..\..\TestFiles\";

      static void Main(string[] args)
      {
         foreach (var file in Directory.GetFiles(Path.Combine(TestFilesDir), "*.*", SearchOption.AllDirectories)) {
            ReadAndWriteTest(file);
         }

         //Debug.WriteLine("Finished");
      }

      private static void ReadAndWriteTest(string path)
      {
         const string OutputPostfix = "_output";
         
         if (Path.GetFileNameWithoutExtension(path).EndsWith(OutputPostfix)) {
            return;
         }
         string outputPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + OutputPostfix +
                             Path.GetExtension(path));

         try {
            CPAScript script = CPAScript.ReadFile(path); // new T();

            File.Delete(outputPath);
            script.Write(File.OpenWrite(outputPath));

         } catch (NotSupportedException e) {
            Debug.WriteLine(e.Message);
         }

      }
   }
}