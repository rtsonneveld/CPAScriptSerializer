using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GLI.Sections {
   public class EditListModifGeometric : EmptySection
   {
      public EditListModifGeometric(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public const string Name = "Edit-ListModifGeometric";
      public override string SectionExportType => Name;
   }
}
