using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class RandomManagerDescription : CPAScriptSection {
      public RandomManagerDescription(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(InitRandomManager), typeof(InitRandomManager)},
      };
   }
}
