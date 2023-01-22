using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.Channel;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D
{
    public class Channel : CPAScriptSection {
      public Channel(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         {nameof(TrajectorySettings), typeof(TrajectorySettings)},
         {nameof(ActiveStatus), typeof(ActiveStatus)},
         {nameof(IsCamera), typeof(IsCamera)},

         // Subsections
         {nameof(Frame), typeof(Frame)},
         {nameof(Key), typeof(Key)},
      };
   }
}
