using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class Chromakey : Command
   {
      [CommandParameter(0)] public EnumChromaKeyEnabled Enable;
      [CommandParameter(1)] public EnumChromaKeyFilter Filter;
      [CommandParameter(2)] public byte Red;
      [CommandParameter(3)] public byte Green;
      [CommandParameter(4)] public byte Blue;
      [CommandParameter(5)] public byte Alpha;
   }
}
