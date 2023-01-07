using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.CAR.Micro;
using CPAScriptSerializer.Modules.SPO.Commands.Matrix;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class Micro : CPAScriptSection
   {
      public Micro(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(MatrixRotation), typeof(MatrixRotation)},
         {nameof(MatrixTranslation), typeof(MatrixTranslation)},
         {nameof(MicroIsActive), typeof(MicroIsActive)},
         {nameof(MicroIsInactive), typeof(MicroIsInactive)},
      };
   }
}
