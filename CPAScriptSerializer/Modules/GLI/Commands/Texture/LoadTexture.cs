using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class LoadTexture : Command
   {
      [CommandParameter(0)] public string Filename;
   }
}
