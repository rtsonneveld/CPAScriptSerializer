using CPAScriptSerializer.Modules.SND.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndTrackM : CPAScriptSection
   {

      [CommandParameter(0)] public int Index;

      public SndTrackM(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(LoadResource), typeof(LoadResource.LoadResourceM)},
         {nameof(SetXIOFades), typeof(SetXIOFades)},
      };
   }
}
