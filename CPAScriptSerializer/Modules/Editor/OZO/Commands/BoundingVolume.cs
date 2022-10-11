using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Sections;

namespace CPAScriptSerializer.Modules.Editor.OZO.Commands {
   public class BoundingVolume : Command
   {
      [CommandParameter(0)]
      public CPAScriptReference<Geometric> Geometric;
   }
}
