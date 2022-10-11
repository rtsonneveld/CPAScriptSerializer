using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TGM.Enums;

namespace CPAScriptSerializer.Modules.Editor.TGM.Commands {
   public class Collision : Command
   {
      [CommandParameter(0)] public EnumZoneType ZoneType;
      // Should be short but there's a value that's 32768
      [CommandParameter(1)] public int Flags;
   }
}
