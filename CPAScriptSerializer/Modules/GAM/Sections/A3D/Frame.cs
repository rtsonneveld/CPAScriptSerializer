using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.Frame;

using Object = CPAScriptSerializer.Modules.GAM.Commands.A3D.Frame.Object;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D
{
   public class Frame : CPAScriptSection {
      public Frame(string sectionId, string sectionType = null) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         {nameof(ObjectType),       typeof(ObjectType)},
         {nameof(Bank),             typeof(Bank)},
         {nameof(Object),           typeof(Object)},
         {nameof(NumberInTable),    typeof(NumberInTable)},
         {nameof(IncludingBox),     typeof(IncludingBox)},
         {nameof(Position),         typeof(Position)},
         {nameof(Orientation),      typeof(Orientation)},
         {nameof(Scale),            typeof(Scale)},
         {nameof(PivotPosition),    typeof(PivotPosition)},
         {nameof(PivotOrientation), typeof(PivotOrientation)},
         {nameof(Transparency),     typeof(Transparency)},
         {nameof(Morphing),         typeof(Morphing)},
         {nameof(FakeProperties),   typeof(FakeProperties)},

         // Sections
         {nameof(Key),              typeof(Key)},
      };
   }
}
