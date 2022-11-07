using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Sections;
using CPAScriptSerializer.Modules.GMT.Enums;

namespace CPAScriptSerializer.Modules.GMT.Commands.Material {
   public class Scroll : Command
   {
      [CommandParameter(0)] public int Index; // Unused?
      [CommandParameter(1)] public float ScrollU;
      [CommandParameter(2)] public float ScrollV;
   }
}
