using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.SPO.Sections {

   public class Edit_ListModifSuperObject : CPAScriptSection
   {
      public const string SectionName = "Edit-ListModifSuperObject";

      public Edit_ListModifSuperObject(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>();
      public override Type CommandTypeFallback(string name) => null;

      public override string SectionExportType => SectionName;
   }
}
