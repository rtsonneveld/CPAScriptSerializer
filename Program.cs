using System;
using System.Diagnostics;
using System.IO;
using CPAScriptSerializer.Modules.AI;

namespace CPAScriptSerializer {
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

         CPAScript wayTest = new CPAScript_WAY();
         wayTest.Read(File.OpenRead(Path.Combine(TestFilesDir, "AI", "embranchmnt.wp")));
         wayTest.Write(File.OpenWrite(Path.Combine(TestFilesDir, "AI", "embranchmnt_WriteTest.wp")));

         Debug.WriteLine("Finished");
      }
   }
}
