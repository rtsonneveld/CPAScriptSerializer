using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GLI.Commands.ElementSprites {
   public class AddSprite : Command {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public int CenterPoint;
      [CommandParameter(2)] public float SizeX;
      [CommandParameter(3)] public float SizeY;
      [CommandParameter(4)] public CPAScriptReference<Sections.Sprite> Sprite;
   }
}
