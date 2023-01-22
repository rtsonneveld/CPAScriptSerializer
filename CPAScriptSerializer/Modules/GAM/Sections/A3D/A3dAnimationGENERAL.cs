using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dAnimationGENERAL;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class A3dAnimationGENERAL : CPAScriptSection {
      public A3dAnimationGENERAL(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Actor), typeof(Actor) },
         { nameof(NumberOfChannels), typeof(NumberOfChannels) },
         { nameof(NumberOfFrames), typeof(NumberOfFrames) },
         { nameof(CurrentFrame), typeof(CurrentFrame) },
         { nameof(AnimationTranslationOffset), typeof(AnimationTranslationOffset) },
         { nameof(AnimationRotationOffset), typeof(AnimationRotationOffset) },
         { nameof(AnimReferenceChannel), typeof(AnimReferenceChannel) },
         { nameof(AnimationSpeed), typeof(AnimationSpeed) },
         { nameof(CameraAngle), typeof(CameraAngle) },
         { nameof(NBOfFramesForInterAnimInterpol), typeof(NBOfFramesForInterAnimInterpol) },
      };
   }
}
