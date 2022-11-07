using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.MEC.Commands;

namespace CPAScriptSerializer.Modules.MEC.Sections {
   public class IdCardCamera : CPAScriptSection {
      public IdCardCamera(string sectionId) : base(sectionId)
      {
      }

      public class CameraCommand : Command
      {
         [CommandParameter(0)] public float Value;
      }

      private string AngularSpeed = "AngularSpeed";
      private string LinearSpeed = "LinearSpeed";
      private string SpeedingUp = "SpeedingUp";

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AngularSpeed), typeof(CameraCommand)},
         {nameof(LinearSpeed), typeof(CameraCommand)},
         {nameof(SpeedingUp), typeof(CameraCommand)},
      };

      
   }
}
