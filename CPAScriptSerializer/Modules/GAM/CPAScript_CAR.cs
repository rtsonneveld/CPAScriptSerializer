using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Sections.CAR;
using CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_;
using CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_.Brain_;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_CAR : CPAScript
   {

      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      { 
         {nameof(Character), typeof(Character)},

         #region Subsections

         {_3dData.Name, typeof(_3dData)},
         {nameof(Brain), typeof(Brain)},

         #region Brain Subsections
            { nameof(InitComportIntelligence), typeof(InitComportIntelligence) },
            { nameof(InitComportReflex), typeof(InitComportReflex) },
            { nameof(InitVariables), typeof(InitVariables) },
         #endregion

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

         #endregion

      };


   }
}
