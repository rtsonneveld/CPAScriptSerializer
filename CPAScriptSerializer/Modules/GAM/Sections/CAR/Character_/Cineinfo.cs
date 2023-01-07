using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class Cineinfo : CPAScriptSection {

      public Cineinfo(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(ShiftTarget), typeof(ShiftTarget) },
         { nameof(ShiftPos), typeof(ShiftPos) },
         { nameof(Distance), typeof(Distance) },
         { nameof(Alpha), typeof(Alpha) },
         { nameof(Theta), typeof(Theta) },
         { nameof(LinearSpeed), typeof(LinearSpeed) },
         { nameof(AngularSpeed), typeof(AngularSpeed) },
         { nameof(TargetSpeed), typeof(TargetSpeed) },
         { nameof(DNMFlags), typeof(DNMFlags) },
         { nameof(IAFlags), typeof(IAFlags) },
         { nameof(Focal), typeof(Focal) },
         { nameof(ZMinMax), typeof(ZMinMax) },
         { nameof(Viewport), typeof(Viewport) },
         { nameof(Channel), typeof(Channel) },
         { nameof(Activation), typeof(Activation) },
      };
   }
}
