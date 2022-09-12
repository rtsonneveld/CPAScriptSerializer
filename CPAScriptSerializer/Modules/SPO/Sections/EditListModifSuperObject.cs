namespace CPAScriptSerializer.Modules.SPO.Sections {
   public class EditListModifSuperObject : EmptySection
   {
      public EditListModifSuperObject(string sectionId) : base(sectionId)
      {
      }

      public const string Name = "Edit-ListModifSuperObject";
      public override string SectionExportType => Name;
   }
}
