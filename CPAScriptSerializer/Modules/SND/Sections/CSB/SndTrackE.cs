using CPAScriptSerializer.Modules.SND.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndTrackE : CPAScriptSection
   {

      [CommandParameter(0)] public int Index;

      public SndTrackE(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(LoadResource), typeof(LoadResource.LoadResourceE)},
      };
   }
}
