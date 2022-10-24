using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {

   public class Anim_Effect
   {

      public class Shift_Phase : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShiftPhase;
      };

      public class Shift_Max : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShiftMax;
      };

      public class Shift_Plus : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShiftPlus;
      };

   }
}
