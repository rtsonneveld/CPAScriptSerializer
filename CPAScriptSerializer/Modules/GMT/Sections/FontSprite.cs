using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Commands;

namespace CPAScriptSerializer.Modules.GMT.Sections {

   // Unused in R2 but here's a stub anyway

   [UnusedByCPA]
   public class FontSprite : CPAScriptSection
   {
      [CommandParameter(0)] public int Arg0;
      [CommandParameter(1)] public float Arg1;
      [CommandParameter(2)] public string Standard;

      public FontSprite(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Letter), typeof(Letter) },
      };
   }
}
