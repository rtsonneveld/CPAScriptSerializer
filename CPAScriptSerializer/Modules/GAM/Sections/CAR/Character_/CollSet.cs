using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.CAR.CollSet;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class CollSet : CPAScriptSection {

      public CollSet(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CharacterPriority), typeof(CharacterPriority)},
         {nameof(CollComputeFrequency), typeof(CollComputeFrequency)},
         {nameof(CollisionFlag), typeof(CollisionFlag)},

         {nameof(ZdmTable), typeof(ZdmTable)},
         {nameof(ZddTable), typeof(ZddTable)},
         {nameof(ZdeTable), typeof(ZdeTable)},
         {nameof(ZdrTable), typeof(ZdrTable)},

         {nameof(ZdmActivationTable), typeof(ZdmActivationTable)},
         {nameof(ZddActivationTable), typeof(ZddActivationTable)},
         {nameof(ZdeActivationTable), typeof(ZdeActivationTable)},
         {nameof(ZdrActivationTable), typeof(ZdrActivationTable)},
      };

   }
}
