using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPAScriptSerializer.IPT.Sections;

namespace CPAScriptSerializer.IPT {

	public class CPAScript_IPT : CPAScript
	{
		public override Dictionary<string, Type> SectionTypes { get; } = new()
		{
			{nameof(InputAction), typeof(InputAction)},
		};
	}
}
