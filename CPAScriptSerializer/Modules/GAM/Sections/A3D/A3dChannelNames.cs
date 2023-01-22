using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dChannelNames;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D
{
   public class A3dChannelNames : CPAScriptSection {

      [CommandParameter(0)] public int NumberOfChannels;

      public A3dChannelNames(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddChannelName), typeof(AddChannelName) },
      };

      
   }
}
