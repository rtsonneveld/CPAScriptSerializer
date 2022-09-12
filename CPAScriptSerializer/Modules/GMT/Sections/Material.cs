using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GMT.Commands.Material;
using Type = System.Type;

namespace CPAScriptSerializer.Modules.GMT.Sections {
   public class Material : CPAScriptSection {

      public Material(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Commands.Material.Type), typeof(Commands.Material.Type)},
         {nameof(AmbientColor), typeof(AmbientColor)},
         {nameof(DiffuseColor), typeof(DiffuseColor)},
         {nameof(SpecularColor), typeof(SpecularColor)},
         {nameof(Backface), typeof(Backface)},
         {nameof(AddTexture), typeof(AddTexture)},
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
