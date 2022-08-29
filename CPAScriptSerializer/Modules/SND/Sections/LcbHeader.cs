using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections {
	public class LcbHeader : CPAScriptSection {

		public LcbHeader(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         { nameof(SetDefaultLanguage), typeof(SetDefaultLanguage) },
         { nameof(VersionNumber), typeof(VersionNumber) },
         { nameof(SetNextFreeGroupId), typeof(SetNextFreeGroupId) },
         
      };

      public override Type CommandTypeFallback => null;
   }
}
