using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class GameOptionsFile : CPAScriptSection {
      public GameOptionsFile(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(DefaultFile), typeof(DefaultFile)},
         {nameof(CurrentFile), typeof(CurrentFile)},
         {nameof(FrameSynchro), typeof(FrameSynchro)},
      };
   }
}
