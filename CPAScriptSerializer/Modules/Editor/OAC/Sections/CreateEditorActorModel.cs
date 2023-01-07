using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.OAC.Sections {
   public class CreateEditorActorModel : CPAScriptSection {
      public CreateEditorActorModel(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(MiniStructure), typeof(MiniStructure)},

         // Commands
         {nameof(Commands.Type), typeof(Commands.Type)},
         {nameof(Commands.Bitmap), typeof(Commands.Bitmap)},
         {nameof(Commands.Family), typeof(Commands.Family)},
         {nameof(Commands.EditorBrain), typeof(Commands.EditorBrain)},
         {nameof(Commands.ShowPrivate), typeof(Commands.ShowPrivate)},
      };
   }
}
