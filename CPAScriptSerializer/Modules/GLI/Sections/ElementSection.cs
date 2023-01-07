using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GLI.Sections {
   public abstract class ElementSection : CPAScriptSection {
      protected ElementSection(string sectionId, string sectionType) : base(sectionId, sectionType) { }
   }
}
