using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {
   public class CollisionSet {
      public class Character_Priority : MiniStructureCommandBase {[CommandParameter(1)] /* TODO: 0/1 boolean?*/ public int Character_PriorityValue; }
      public class Collision_Flag : MiniStructureCommandBase {[CommandParameter(1)] public EnumCollisionFlags Flags; }
      public class No_Collision_With_Map : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_MapValue; }
      public class No_Collision_With_Map_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Map_InitValue; }
      public class No_Collision_With_Projectile : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_ProjectileValue; }
      public class No_Collision_With_Projectile_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Projectile_InitValue; }
      public class No_Collision_With_Secondary_Character : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Secondary_CharacterValue; }
      public class No_Collision_With_Secondary_Character_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Secondary_Character_InitValue; }
      public class No_Collision_With_Main_Character : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Main_CharacterValue; }
      public class No_Collision_With_Main_Character_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Main_Character_InitValue; }
      public class Force_Collision_When_Not_Moving : MiniStructureCommandBase {[CommandParameter(1)] public bool Force_Collision_When_Not_MovingValue; }
      public class Force_Collision_When_Not_Moving_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool Force_Collision_When_Not_Moving_InitValue; }
      public class No_Collision_With_Other_Sectors : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Other_SectorsValue; }
      public class No_Collision_With_Other_Sectors_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_With_Other_Sectors_InitValue; }
      public class No_Collision_Zde_With_Projectile : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_Zde_With_ProjectileValue; }
      public class No_Collision_Zde_With_Projectile_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool No_Collision_Zde_With_Projectile_InitValue; }
      public class Collision_Frequency : MiniStructureCommandBase {[CommandParameter(1)] public int Collision_FrequencyValue; }
      public class Collision_Frequency_Init : MiniStructureCommandBase {[CommandParameter(1)] public int Collision_Frequency_InitValue; }
      
      public class MiniStructureCommandZDX : MiniStructureCommandBase {
         [CommandParameter(1)] public string CreateNamesList;
         [CommandParameter(2)] public string ObjectListName;
         [CommandParameter(3)] public string ActivationListName;
      }

      public class ZDE : MiniStructureCommandZDX {}
      public class ZDM : MiniStructureCommandZDX {}
      public class ZDD : MiniStructureCommandZDX {}
      public class ZDR : MiniStructureCommandZDX {}
   }
}
