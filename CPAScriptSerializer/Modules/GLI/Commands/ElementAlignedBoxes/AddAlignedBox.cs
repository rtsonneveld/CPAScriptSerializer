using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Sections;

namespace CPAScriptSerializer.Modules.GLI.Commands.ElementAlignedBoxes {
   public class AddAlignedBox : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public int MinPointIndex;
      [CommandParameter(2)] public int MaxPointIndex;
      [CommandParameter(3)] public CPAScriptReference<GameMaterial> GameMaterial;
   }
}
