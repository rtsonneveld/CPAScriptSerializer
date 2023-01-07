using System;
using System.Collections.Generic;
using System.Linq;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Commands.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.LVL;
using CPAScriptSerializer.Modules.SPO.Commands.Matrix;
using InitialState = CPAScriptSerializer.Modules.GAM.Commands.LVL.InitialState;

namespace CPAScriptSerializer.Modules.GAM.Sections.LVL {
   public class InsertCharacter : CPAScriptSection
   {
      public const string FlagStandardCamera = "StandardCamera";
      public const string FlagPrincipalActor = "PrincipalActor";
      public const string FlagActorLaunchingSounds = "ActorLaunchingSounds";
      public const string FlagActorLauchingSounds = "ActorLauchingSounds";

      private const string CharacterIsInAllSubmaps = "CharacterIsInAllSubmaps";
      [CommandParameter(0)] public string OptionalParam1;
      [CommandParameter(1)] public string OptionalParam2;
      [CommandParameter(2)] public string OptionalParam3;
      
      public bool StandardCamera { get => HasParamFlag(FlagStandardCamera); set => UpdateParamFlags(value, null, null); }
      public bool PrincipalActor { get => HasParamFlag(FlagPrincipalActor); set => UpdateParamFlags(null, value, null); }
      public bool ActorLaunchingSounds { get => HasParamFlag(FlagActorLaunchingSounds) || HasParamFlag(FlagActorLauchingSounds); set => UpdateParamFlags(null, null, value);
      }

      private bool HasParamFlag(string flagName)
      {
         return OptionalParam1.ToLower() == flagName.ToLower() ||
                OptionalParam2.ToLower() == flagName.ToLower() ||
                OptionalParam3.ToLower() == flagName.ToLower();
      }

      private void UpdateParamFlags(bool? newStandardCameraValue, bool? newPrincipalActorValue, bool? newActorLaunchingSoundsValue)
      {
         bool flagStandardCamera = StandardCamera;
         bool flagPrincipalActor = PrincipalActor;
         bool flagActorLaunchingSounds = ActorLaunchingSounds;

         if (newStandardCameraValue != null) { flagStandardCamera = newStandardCameraValue.Value; }
         if (newPrincipalActorValue != null) { flagPrincipalActor = newPrincipalActorValue.Value; }
         if (newActorLaunchingSoundsValue != null) { flagActorLaunchingSounds = newActorLaunchingSoundsValue.Value; }

         List<string> flags = new List<string>();
         if (flagStandardCamera) flags.Add(FlagStandardCamera);
         if (flagPrincipalActor) flags.Add(FlagPrincipalActor);
         if (flagActorLaunchingSounds) flags.Add(FlagActorLaunchingSounds);

         OptionalParam1 = flags.FirstOrDefault(); if (flags.Any()) flags.RemoveAt(0);
         OptionalParam2 = flags.FirstOrDefault(); if (flags.Any()) flags.RemoveAt(0);
         OptionalParam3 = flags.FirstOrDefault();
      }

      public InsertCharacter(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LinkCharacter), typeof(LinkCharacter) },
         { nameof(MatrixTranslation), typeof(MatrixTranslation) },
         { nameof(MatrixRotation), typeof(MatrixRotation) },
         { nameof(MatrixScale), typeof(MatrixScale) },
         { nameof(CharacterFlags), typeof(CharacterFlags) },
         { nameof(CharacterIsAlwaysActive), typeof(CharacterIsAlwaysActive) },
         { nameof(Transparency), typeof(Transparency) },
         { nameof(InitialState), typeof(InitialState) },
         { CharacterIsInAllSubmaps, typeof(EmptyCommand) },
      };

      
   }
}
