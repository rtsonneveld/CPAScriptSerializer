using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CPAScriptSerializer.Modules.AI;
using CPAScriptSerializer.Modules.AI.Commands.DEC.Variables;
using CPAScriptSerializer.Modules.GLI;
using CPAScriptSerializer.Modules.GMT;
using CPAScriptSerializer.Modules.IPT;
using CPAScriptSerializer.Modules.MEC;
using CPAScriptSerializer.Modules.SND;
using CPAScriptSerializer.Modules.SPO;
using Newtonsoft.Json;

namespace CPAScriptSerializer
{
   class Program
   {
      private const string TestFilesDir = @"..\..\..\TestGameData\GAMEDATA\";

      static void Main(string[] args)
      {
         List<CPAScript> scripts = new List<CPAScript>();

         foreach (var file in Directory.GetFiles(Path.Combine(TestFilesDir), "*.*", SearchOption.AllDirectories)) {
            var script = ReadAndWriteTest(file);
            if (script != null)
            scripts.Add(script);
         }

         File.Delete("gamedata.json");
         File.WriteAllText($"gamedata.json", JsonConvert.SerializeObject(scripts));

         //Debug.WriteLine("Finished");
      }

      private static CPAScript ReadAndWriteTest(string path)
      {
         const string OutputPostfix = "_output";
         
         if (Path.GetFileNameWithoutExtension(path).EndsWith(OutputPostfix)) {
            return null;
         }
         string outputPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + OutputPostfix +
                             Path.GetExtension(path));

         try {
            CPAScript script = CPAScript.ReadFile(path); // new T();

            File.Delete(outputPath);
            script.Write(File.OpenWrite(outputPath));

            return script;
         } catch (NotSupportedException e) {
            Debug.WriteLine(e.Message);
         }

         return null;
      }
   }
}