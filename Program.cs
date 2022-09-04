using System;
using System.Diagnostics;
using System.IO;
using CPAScriptSerializer.Modules.AI;
using CPAScriptSerializer.Modules.IPT;
using CPAScriptSerializer.Modules.SND;

namespace CPAScriptSerializer
{
   class Program
   {
      private const string TestFilesDir = @"..\..\..\TestFiles\";

      static void Main(string[] args)
      {
         /*
         CPAScript lcbTest = new CPAScript_LCB();
         lcbTest.Read(File.OpenRead(Path.Combine(TestFilesDir, "SND","Rayman2.lcb")));
         lcbTest.Write(File.OpenWrite(Path.Combine(TestFilesDir, "SND","Rayman2_WriteTest.lcb")));
         */


         CPAScript csbTest = new CPAScript_CSB();
         csbTest.Read(File.OpenRead(Path.Combine(TestFilesDir, "SND", "nature.csb")));
         csbTest.Write(File.OpenWrite(Path.Combine(TestFilesDir, "SND", "nature_WriteTest.csb")));

         /*
         foreach (var file in Directory.GetFiles(Path.Combine(TestFilesDir, "IPT"))) {
            CPAScript iptTest = new CPAScript_IPT();
            iptTest.Read(File.OpenRead(file));

            string newFileName = Path.GetFileNameWithoutExtension(file) + "_writetest" + Path.GetExtension(file);
            iptTest.Write(File.OpenWrite(Path.Combine(Path.GetDirectoryName(file), "Output", newFileName)));
         }*/

         Debug.WriteLine("Finished");
      }
   }
}