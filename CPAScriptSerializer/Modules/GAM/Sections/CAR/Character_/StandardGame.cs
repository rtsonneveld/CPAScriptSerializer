using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame;
using Type = System.Type;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class StandardGame : CPAScriptSection {

      public StandardGame(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Commands.CAR.StandardGame.Type), typeof(Commands.CAR.StandardGame.Type) },
         { nameof(HitPointsInit), typeof(HitPointsInit) },
         { nameof(HitPointsMaxInit), typeof(HitPointsMaxInit) },
         { nameof(HitPointsMaxMax), typeof(HitPointsMaxMax) },
         { nameof(InitFlags), typeof(InitFlags) },
         { nameof(PlatFormType), typeof(PlatFormType) },
         { nameof(CustomBitsInit), typeof(CustomBitsInit) },
         { nameof(Capabilities), typeof(Capabilities) },
         { nameof(TransparencyZone), typeof(TransparencyZone) },
         { nameof(TooFarLimit), typeof(TooFarLimit) },
      };

      
   }
}
