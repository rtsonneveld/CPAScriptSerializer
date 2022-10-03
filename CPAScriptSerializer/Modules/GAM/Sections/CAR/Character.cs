using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR {
   public class Character : CPAScriptSection {
      public Character(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {_3dData.Name, typeof(_3dData)},
         {nameof(Brain), typeof(Brain)},
         {nameof(CollSet), typeof(CollSet)},
         {nameof(Dynam), typeof(Dynam)},
         {nameof(MSWay), typeof(MSWay)},
         {nameof(SectInfo), typeof(SectInfo)},
         {nameof(StandardGame), typeof(StandardGame)},
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
