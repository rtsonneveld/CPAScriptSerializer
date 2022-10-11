using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.STA;

namespace CPAScriptSerializer.Modules.GAM.Sections.STA {
   public class CreateNewState : CPAScriptSection
   {
      public CreateNewState(string sectionId) : base(sectionId) { }

      [CommandParameter(0)]
      public string StateName;

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Animation), typeof(Animation)},
         {nameof(Repeat), typeof(Repeat)},
         {nameof(Speed), typeof(Speed)},
         {nameof(TransitionStatusFlag), typeof(TransitionStatusFlag)},
         {nameof(LinkMechanics), typeof(LinkMechanics)},
         {nameof(AddTargetState), typeof(AddTargetState)},
         {nameof(NextState), typeof(NextState)},
         {nameof(CustomBits), typeof(CustomBits)},
         {nameof(ProhibitedTargetState), typeof(ProhibitedTargetState)},
      };
      
   }
}
