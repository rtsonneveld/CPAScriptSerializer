using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.OSC.Sections {
   public class Gothrough : CPAScriptSection {
      public Gothrough(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Commands.GoThrough), typeof(Commands.GoThrough) },
      };
   }
}
