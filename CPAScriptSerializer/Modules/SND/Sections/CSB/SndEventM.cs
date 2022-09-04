using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands.CSB;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndEventM;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndEventM : CPAScriptSection {
      public SndEventM(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetName), typeof(SetName) },
         { nameof(SetComment), typeof(SetComment) },
         { nameof(SetParam1), typeof(SetParam1) },
         { nameof(SetParam2), typeof(SetParam2) },
         { nameof(SetParam3), typeof(SetParam3) },
         { nameof(SetParam4), typeof(SetParam4) },
         { nameof(SetStopable), typeof(SetStopable) },
         { nameof(SetDynamic), typeof(SetDynamic) },
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
