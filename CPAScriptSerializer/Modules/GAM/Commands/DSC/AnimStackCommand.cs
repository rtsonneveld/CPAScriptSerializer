using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class AnimStackCommand : Command
   {
      [CommandParameter(0)] public int StackSize;

      public const string A3dGeneral = "A3dGeneral";
      public const string Vertexes = "Vertexes";
      public const string Quaternions = "Quaternions";
      public const string Hierarchies = "Hierarchies";
      public const string NTTO = "NTTO";
      public const string OnlyFrames = "OnlyFrames";
      public const string Channels = "Channels";
      public const string Frames = "Frames";
      public const string FramesKF = "FramesKF";
      public const string KeyFrames = "KeyFrames";
      public const string Events = "Events";
      public const string MorphData = "MorphData";
   }
}
