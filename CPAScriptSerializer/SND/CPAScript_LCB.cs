using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.SND {
	public class CPAScript_LCB : CPAScript{
		public override Dictionary<string, Type> SectionTypes { get; } = new()
		{
			{ nameof(Sections.LcbHeader), typeof(Sections.LcbHeader) },
			{ nameof(Sections.SndEventGroupList), typeof(Sections.SndEventGroupList) },
			{ nameof(Sections.SndBankE), typeof(Sections.SndBankE) },
			{ nameof(Sections.SndMapE), typeof(Sections.SndMapE) },
			{ nameof(Sections.SndEventIdList), typeof(Sections.SndEventIdList) },
			{ nameof(Sections.SndResIdList), typeof(Sections.SndResIdList) },
		};
	}
}
