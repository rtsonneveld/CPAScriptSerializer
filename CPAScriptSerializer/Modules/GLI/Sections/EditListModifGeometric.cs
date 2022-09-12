using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GLI.Sections {
   public class EditListModifGeometric : EmptySection
   {
      public EditListModifGeometric(string sectionId) : base(sectionId) { }

      public const string Name = "Edit-ListModifGeometric";
      public override string SectionExportType => Name;
   }
}
