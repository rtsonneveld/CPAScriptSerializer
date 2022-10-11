using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.PO.Sections;

namespace CPAScriptSerializer.Modules.PO.Commands {
   
   // Visual set
   public class VS : Command
   {
      [CommandParameter(0)] public CPAScriptReference<Modules.Editor.OZO.Sections.VS> VisualSet;
   };
}

