using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TAC.Sections;

namespace CPAScriptSerializer.Modules.Editor.TAC {
   public class CPAScript_ACZ : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(ArrayOfZoneSet), typeof(ArrayOfZoneSet) },
            { nameof(CreateNewArrayOfZoneSet), typeof(CreateNewArrayOfZoneSet) },
               { nameof(AddActivation), typeof(AddActivation) },

         { nameof(Sections.ActivationZone), typeof(Sections.ActivationZone) },
            { nameof(NewActivationZone), typeof(NewActivationZone) },
         
      };
   }
}
