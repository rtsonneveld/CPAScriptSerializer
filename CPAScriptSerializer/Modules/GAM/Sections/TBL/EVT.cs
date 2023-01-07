using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.TBL.EVT;

namespace CPAScriptSerializer.Modules.GAM.Sections.TBL {
   public class EVT : CPAScriptSection {
      public EVT(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(ObjectType), typeof(ObjectType)},
         {nameof(SoundEvent), typeof(SoundEvent)},
         {nameof(GenericEvent), typeof(GenericEvent)},
         //{nameof(MechanicEvent), typeof(MechanicEvent)}, -- Mechanic Event was removed from CPA
         //{nameof(GenerateEvent), typeof(GenerateEvent)}, -- Generate Event was removed from CPA

         {nameof(FirstCall), typeof(FirstCall)},
         {nameof(Period), typeof(Period)},
         {nameof(Priority), typeof(Priority)},
      };
   }
}
