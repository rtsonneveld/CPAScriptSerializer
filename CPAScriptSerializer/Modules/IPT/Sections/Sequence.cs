using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.IPT.Commands;
using CPAScriptSerializer.Modules.IPT.Commands.Input;

namespace CPAScriptSerializer.Modules.IPT.Sections {

   // Inherit the commands from InputAction
   public class Sequence : CPAScriptSection {
      
      public const string Key = "Key";
      public const string Pad = "Pad";

      public Sequence(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {Key, typeof(KeyCommand)},
         {Pad, typeof(PadCommand)},
      };

      public override Type CommandTypeFallback => null;
   }
}
