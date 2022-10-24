using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {
   public class Ways {

      public class Reseau : MiniStructureCommandBase { [CommandParameter(1, customDefaultValue: "Pas de Reseau")] public string ReseauName; };
      public class Index : MiniStructureCommandBase { [CommandParameter(1)] public int Value; };
      public class Circulaire : MiniStructureCommandBase { [CommandParameter(1)] public bool IsCircular; };

      [UnusedByCPA]
      // Object list similar to ZDX, but unused
      public class Way : CollisionSet.MiniStructureCommandZDX { };
   }
}
