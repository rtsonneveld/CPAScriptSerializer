using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {

   public class DirectoryCommand : Command {
      public const string DirectoryOfAnimations = "DirectoryOfAnimations";
      public const string DirectoryOfCharacters = "DirectoryOfCharacters";
      public const string DirectoryOfEffects = "DirectoryOfEffects";
      public const string DirectoryOfEngineDLL = "DirectoryOfEngineDLL";
      public const string DirectoryOfEnvironment = "DirectoryOfEnvironment";
      public const string DirectoryOfExtras = "DirectoryOfExtras";
      public const string DirectoryOfFamilies = "DirectoryOfFamilies";
      public const string DirectoryOfFixTexture = "DirectoryOfFixTexture";
      public const string DirectoryOfGameData = "DirectoryOfGameData";
      public const string DirectoryOfGraphicsBanks = "DirectoryOfGraphicsBanks";
      public const string DirectoryOfGraphicsClasses = "DirectoryOfGraphicsClasses";
      public const string DirectoryOfLevels = "DirectoryOfLevels";
      public const string DirectoryOfLipsSync = "DirectoryOfLipsSync";
      public const string DirectoryOfMaterials = "DirectoryOfMaterials";
      public const string DirectoryOfMechanics = "DirectoryOfMechanics";
      public const string DirectoryOfOptions = "DirectoryOfOptions";
      public const string DirectoryOfSaveGame = "DirectoryOfSaveGame";
      public const string DirectoryOfSound = "DirectoryOfSound";
      public const string DirectoryOfTexts = "DirectoryOfTexts";
      public const string DirectoryOfTexture = "DirectoryOfTexture";
      public const string DirectoryOfVignettes = "DirectoryOfVignettes";
      public const string DirectoryOfVisuals = "DirectoryOfVisuals";
      public const string DirectoryOfWorld = "DirectoryOfWorld";
      public const string DirectoryOfZdx = "DirectoryOfZdx";

      [CommandParameter(0)] public string Directory;
   }
}
