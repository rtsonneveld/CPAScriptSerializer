using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {

   /// <summary>
   /// No idea what this was used for, seems to mean "Take Put"
   /// </summary>
   [UnusedByCPA]
   public class MSTakPut : CPAScriptSection {
      public MSTakPut(string sectionId, string sectionType) : base(sectionId, sectionType)
      { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {

      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
