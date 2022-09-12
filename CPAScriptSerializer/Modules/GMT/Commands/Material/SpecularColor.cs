using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GMT.Commands.Material {
   public class SpecularColor : Command
   {
      [CommandParameter(0)] public float ColorRed;
      [CommandParameter(1)] public float ColorGreen;
      [CommandParameter(2)] public float ColorBlue;
      [CommandParameter(3)] public float ColorAlpha;
   }
}
