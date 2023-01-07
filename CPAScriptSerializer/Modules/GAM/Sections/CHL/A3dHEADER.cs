using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.CHL;

namespace CPAScriptSerializer.Modules.GAM.Sections.CHL {
   
   // ReSharper disable once InconsistentNaming
   public class A3dHEADER : CPAScriptSection {
      public A3dHEADER(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(FileType), typeof(FileType)},
         {nameof(VersionNumber), typeof(VersionNumber)},
      };
      
   }
}
