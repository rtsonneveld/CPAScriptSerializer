namespace CPAScriptSerializer.Modules.SPO.Sections {
   public class EditListModifSuperObject : EmptySection
   {
      public EditListModifSuperObject(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public const string Name = "Edit-ListModifSuperObject";
      public override string SectionExportType => Name;
   }
}
