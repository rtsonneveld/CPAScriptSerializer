using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands.Generic;
using CPAScriptSerializer.Modules.Editor.OSC.Commands;

namespace CPAScriptSerializer.Modules.Editor.OSC.Sections
{
   public class SectorsLink : CPAScriptSection
   {
      private const string Virtual = "Virtual";

      public SectorsLink(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CameraType), typeof(CameraType) },
         { nameof(Priority), typeof(Priority) },
         { nameof(AddLstGraphic), typeof(AddLstGraphic) },
         { nameof(AddLstCollision), typeof(AddLstCollision) },
         { nameof(AddLstActivity), typeof(AddLstActivity) },
         { Virtual, typeof(EmptyCommand) },
      };
   }
}
