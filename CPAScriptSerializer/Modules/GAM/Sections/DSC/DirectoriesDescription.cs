using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class DirectoriesDescription : CPAScriptSection {
      public DirectoriesDescription(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {DirectoryCommand.DirectoryOfAnimations, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfCharacters, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfEffects, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfEngineDLL, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfEnvironment, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfExtras, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfFamilies, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfFixTexture, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfGameData, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfGraphicsBanks, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfGraphicsClasses, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfLevels, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfLipsSync, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfMaterials, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfMechanics, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfOptions, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfSaveGame, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfSound, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfTexts, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfTexture, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfVignettes, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfVisuals, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfWorld, typeof(DirectoryCommand)},
         {DirectoryCommand.DirectoryOfZdx, typeof(DirectoryCommand)},
      };
   }
}
