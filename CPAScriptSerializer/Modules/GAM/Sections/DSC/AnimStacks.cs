using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class AnimStacks : CPAScriptSection {
      public AnimStacks(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {AnimStackCommand.A3dGeneral, typeof(AnimStackCommand)},
         {AnimStackCommand.Vertexes, typeof(AnimStackCommand)},
         {AnimStackCommand.Quaternions, typeof(AnimStackCommand)},
         {AnimStackCommand.Hierarchies, typeof(AnimStackCommand)},
         {AnimStackCommand.NTTO, typeof(AnimStackCommand)},
         {AnimStackCommand.OnlyFrames, typeof(AnimStackCommand)},
         {AnimStackCommand.Channels, typeof(AnimStackCommand)},
         {AnimStackCommand.Frames, typeof(AnimStackCommand)},
         {AnimStackCommand.FramesKF, typeof(AnimStackCommand)},
         {AnimStackCommand.KeyFrames, typeof(AnimStackCommand)},
         {AnimStackCommand.Events, typeof(AnimStackCommand)},
         {AnimStackCommand.MorphData, typeof(AnimStackCommand)},
      };
   }
}
