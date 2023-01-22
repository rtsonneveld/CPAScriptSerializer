using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.GameData {
   public class ScriptFile : DataFile {

      public readonly CPAScript Script;

      public ScriptFile(string name, CPAScript script) : base(name)
      {
         this.Script = script;
      }
   }
}
