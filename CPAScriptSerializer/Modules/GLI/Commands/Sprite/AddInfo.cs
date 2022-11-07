using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Sprite {
   public class AddInfo : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public EnumSpriteMode SpriteMode;
      [CommandParameter(2)] public float Threshold;
      [CommandParameter(3)] public float SizeX;
      [CommandParameter(4)] public float SizeY;
      [CommandParameter(5)] public float DisplacementX;
      [CommandParameter(6)] public float DisplacementY;
   }
}
