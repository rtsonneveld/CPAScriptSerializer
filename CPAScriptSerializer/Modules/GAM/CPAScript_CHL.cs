using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.DEC;
using CPAScriptSerializer.Modules.GAM.Sections.A3D;

namespace CPAScriptSerializer.Modules.GAM
{
   /// <summary>
   /// Channel names
   /// </summary>
   public class CPAScript_CHL : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(A3dHEADER), typeof(A3dHEADER) },
         { nameof(A3dChannelNames), typeof(A3dChannelNames) },
      };
   }
}