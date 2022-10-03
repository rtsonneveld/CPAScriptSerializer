using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.MEC.Commands;

namespace CPAScriptSerializer.Modules.MEC.Sections {
   public class IdCardBase : CPAScriptSection {
      public IdCardBase(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Animation), typeof(Animation)},
         {nameof(Collide), typeof(Collide)},
         {nameof(Gravity), typeof(Gravity)},
         {nameof(Tilt), typeof(Tilt)},
         {nameof(Gi), typeof(Gi)},
         {nameof(Climb), typeof(Climb)},
         {nameof(OnGround), typeof(OnGround)},
         {nameof(Spider), typeof(Spider)},
         {nameof(Shoot), typeof(Shoot)},
         {nameof(Swim), typeof(Swim)},
         {nameof(CollisionControl), typeof(CollisionControl)},
         {nameof(KeepSpeedZ), typeof(KeepSpeedZ)},
         {nameof(SpeedLimit), typeof(SpeedLimit)},
         {nameof(Inertia), typeof(Inertia)},
         {nameof(Stream), typeof(Stream)},
         {nameof(StickOnPlatform), typeof(StickOnPlatform)},
         {nameof(Scale), typeof(Scale)},
         {nameof(G), typeof(G)},
         {nameof(Slide), typeof(Slide)},
         {nameof(Rebound), typeof(Rebound)},
         {nameof(SlopeLimit), typeof(SlopeLimit)},
         {nameof(Ix), typeof(Ix)},
         {nameof(Iy), typeof(Iy)},
         {nameof(Iz), typeof(Iz)},
         {nameof(TiltIntensity), typeof(TiltIntensity)},
         {nameof(TiltInertia), typeof(TiltInertia)},
         {nameof(TiltOrigin), typeof(TiltOrigin)},
         {nameof(MaxSpeed), typeof(MaxSpeed)},
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
