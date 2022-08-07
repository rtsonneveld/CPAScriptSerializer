using System;
using System.Diagnostics;
using System.IO;
using CPAScriptSerializer.SND;

namespace CPAScriptSerializer {
   class Program
   {
      private const string TestFilesDir = @"..\..\..\TestFiles\";

      static void Main(string[] args)
      {
         CPAScript lcbTest = new CPAScript_LCB();
         lcbTest.Read(File.OpenRead(Path.Combine(TestFilesDir, "SND","Rayman2.lcb")));

         Debug.WriteLine("Finished");
      }
   }
}
