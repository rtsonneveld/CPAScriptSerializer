﻿using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.SuperObject {
   public class PutMatrix : Command
   {
      [CommandParameter(0)] public CPAScriptReference<Sections.Matrix> MatrixRef;
   }
}
