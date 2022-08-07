using System;
using System.Collections.Generic;
using System.IO;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.SND.Commands;

namespace CPAScriptSerializer.SND.Sections {
	public class LcbHeader : CPAScriptSection {

		public LcbHeader(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         { nameof(SetDefaultLanguage), typeof(SetDefaultLanguage) },
         { nameof(VersionNumber), typeof(VersionNumber) },
         { nameof(SetNextFreeGroupId), typeof(SetNextFreeGroupId) },
         
      };

		public override void WriteContent(StreamWriter writer)
		{
			throw new NotImplementedException();
		}
   }
}
