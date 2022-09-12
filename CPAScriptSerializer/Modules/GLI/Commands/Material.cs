using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Sections;

namespace CPAScriptSerializer.Modules.GLI.Commands {
   public class Material : Command
   {
      [CommandParameter(0)] public CPAScriptReference<GameMaterial> MaterialReference;
   }
}
