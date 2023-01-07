using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OZO.Commands;

namespace CPAScriptSerializer.Modules.Editor.OZO.Sections {
   public class CreateNewArrayOfZdx : CPAScriptSection
   {

      [CommandParameter(0)] public string ZoneType;
      [CommandParameter(1)] public int NumberOfZdx; // TODO: Validate

      public CreateNewArrayOfZdx(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(GeometricObject), typeof(GeometricObject)},
         {nameof(Nothing), typeof(Nothing)},
      };
   }
}
