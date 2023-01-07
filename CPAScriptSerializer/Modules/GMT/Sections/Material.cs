using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GMT.Commands.Material;
using Type = System.Type;

namespace CPAScriptSerializer.Modules.GMT.Sections {
   public class Material : CPAScriptSection {

      public Material(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Commands.Material.Type), typeof(Commands.Material.Type)},
         {nameof(AmbientColor), typeof(AmbientColor)},
         {nameof(DiffuseColor), typeof(DiffuseColor)},
         {"DiffusionColor", typeof(DiffuseColor)}, // Old name, seemingly
         {nameof(SpecularColor), typeof(SpecularColor)},
         {nameof(Backface), typeof(Backface)},
         {nameof(AddTexture), typeof(AddTexture)},
         {nameof(Scroll), typeof(Scroll)},
      };

      
   }
}
