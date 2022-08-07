using System;
using System.Collections.Generic;
using System.IO;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.SND.Commands;

namespace CPAScriptSerializer.IPT.Sections {
	public class InputAction : CPAScriptSection {

		public InputAction(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(SetDefaultLanguage), typeof(SetDefaultLanguage)},
      };


		public override void WriteContent(StreamWriter writer)
		{
			throw new NotImplementedException();
		}
	}
}
