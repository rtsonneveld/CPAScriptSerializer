using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class Dynam : CPAScriptSection
   {

      [CommandParameter(0)] public EnumDynamSize DynamSize;
      [CommandParameter(1)] public int EnableCollision;

      public Dynam(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; }
      public override Type CommandTypeFallback(string name) => null;
   }
}
