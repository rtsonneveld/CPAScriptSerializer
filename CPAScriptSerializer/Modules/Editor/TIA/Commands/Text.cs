using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.TIA.Commands {
   public class Text : Command
   {
      [CommandParameter(0)] public string Value;
   }
}
