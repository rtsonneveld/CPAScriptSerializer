using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.CollSet {
   public class CollisionFlag : Command {
      /// <summary>
      /// NO_COLLISION_WITH_MAP                   0x01
      /// NO_COLLISION_WITH_PROJECTILE            0x02
      /// NO_COLLISION_WITH_SECONDARY_CHARACTER   0x04
      /// NO_COLLISION_WITH_MAIN_CHARACTER        0x08
      /// FORCE_COLLISION_WHEN_NOT_MOVING         0x10
      /// NO_COLLISION_WITH_OTHER_SECTORS         0x20
      /// NO_COLLISION_ZDE_WITH_PROJECTILE        0x40
      /// </summary>
      [CommandParameter(0)] public int Flag;

   }
}
