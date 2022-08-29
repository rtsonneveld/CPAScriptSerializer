using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.IPT.Sections {
	public class InputAction : CPAScriptSection {

		public InputAction(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(SetDefaultLanguage), typeof(SetDefaultLanguage)},
      };

      public override Type CommandTypeFallback => null;
   }
}
