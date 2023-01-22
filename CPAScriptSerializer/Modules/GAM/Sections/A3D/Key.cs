using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.Key;
using Type = System.Type;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D
{
   public class Key : CPAScriptSection {
      public Key(string sectionId, string sectionType = null) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new ()
      {
         {nameof(Attribute), typeof(Attribute)},
         {nameof(Mask), typeof(Mask)},
         {nameof(Commands.A3D.Key.Type), typeof(Commands.A3D.Key.Type)},
      };
   }
}
