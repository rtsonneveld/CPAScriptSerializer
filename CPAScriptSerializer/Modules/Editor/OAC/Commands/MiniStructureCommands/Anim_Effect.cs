using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {

   public class Anim_Effect
   {

      public class Shift_Phase : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShiftPhaseX;
         [CommandParameter(2)] public float ShiftPhaseY;
         [CommandParameter(3)] public float ShiftPhaseZ;
      };

      public class Shift_Max : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShiftMaxX;
         [CommandParameter(2)] public float ShiftMaxY;
         [CommandParameter(3)] public float ShiftMaxZ;
      };

      public class Shift_Plus : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShiftPlusX;
         [CommandParameter(2)] public float ShiftPlusY;
         [CommandParameter(3)] public float ShiftPlusZ;
      };

   }
}
