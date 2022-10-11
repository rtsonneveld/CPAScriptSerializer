using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.TIA.Commands {
   public class BoundingBox : Command
   {
      [CommandParameter(0)]
      public int Left;
      [CommandParameter(1)]
      public int Top;
      [CommandParameter(2)]
      public int Right;
      [CommandParameter(3)]
      public int Bottom;
   }
}
