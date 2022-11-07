using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.TGM.Commands {
   public class MaterialProperty : Command
   {
      [CommandParameter(0)] public float Value;
   }
}
