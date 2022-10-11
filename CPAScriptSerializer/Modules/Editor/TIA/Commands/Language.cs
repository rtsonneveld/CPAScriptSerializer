using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TIA.Enums;

namespace CPAScriptSerializer.Modules.Editor.TIA.Commands {
   public class Language : Command
   {
      [CommandParameter(0)] public EnumLanguage Value;
   }
}
