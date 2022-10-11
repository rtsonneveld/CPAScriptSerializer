using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OZO.Commands;

namespace CPAScriptSerializer.Modules.Editor.OZO.Sections {
   public class CreateNewArrayOfZdx : CPAScriptSection {
      public CreateNewArrayOfZdx(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(GeometricObject), typeof(GeometricObject)},
         {nameof(Nothing), typeof(Nothing)},
      };
   }
}
