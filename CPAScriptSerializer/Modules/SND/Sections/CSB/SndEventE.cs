using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB
{
   public class SndEventE : CPAScriptSection
   {
      [CommandParameter(0)]
      public string SndEventM;

      public SndEventE(string sectionId, string sectionType) : base(sectionId, sectionType)
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
      };

      
   }
}