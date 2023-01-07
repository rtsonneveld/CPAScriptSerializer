using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR {
   public class Character : CPAScriptSection {
      public Character(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {_3dData.Name, typeof(_3dData)},
         {nameof(Brain), typeof(Brain)},
         {nameof(CollSet), typeof(CollSet)},
         {nameof(Dynam), typeof(Dynam)},
         {nameof(MSWay), typeof(MSWay)},
         {nameof(MSSound), typeof(MSSound)},
         {nameof(SectInfo), typeof(SectInfo)},
         {nameof(StandardGame), typeof(StandardGame)},
         {nameof(MSTakPut), typeof(MSTakPut)},
         {nameof(World), typeof(World)},
         {nameof(Cineinfo), typeof(Cineinfo)},
         {nameof(Micro), typeof(Micro)},
         {nameof(MSLight), typeof(MSLight)},
      };

      
   }
}
