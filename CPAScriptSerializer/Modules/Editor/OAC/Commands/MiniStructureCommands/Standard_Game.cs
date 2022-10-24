using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands
{
   public class Standard_Game {

      public class Family_Type : MiniStructureCommandBase { [CommandParameter(1)] public int FamilyType; }
      public class Model_Type : MiniStructureCommandBase { [CommandParameter(1)] public int ModelType; }
      public class Perso_Type : MiniStructureCommandBase { [CommandParameter(1)] public int PersoType; }
      public class Last_Trame : MiniStructureCommandBase { [CommandParameter(1)] public int LastTrame; }
      public class Hit_Points : MiniStructureCommandBase { [CommandParameter(1)] public int HitPoints; }
      public class Initial_Hit_Points : MiniStructureCommandBase { [CommandParameter(1)] public int InitialHitPoints; }
      public class Hit_Points_Max : MiniStructureCommandBase { [CommandParameter(1)] public int HitPointsMax; }
      public class Initial_Hit_Points_Max : MiniStructureCommandBase { [CommandParameter(1)] public int InitialHitPointsMax; }
      public class Hit_Points_Max_Max : MiniStructureCommandBase { [CommandParameter(1)] public int HitPointsMaxMax; }
      public class Desactivate_At_All : MiniStructureCommandBase { [CommandParameter(1)] public bool DesactivateAtAll; }
      public class Activable : MiniStructureCommandBase { [CommandParameter(1)] public bool IsActivable; }
      public class Active : MiniStructureCommandBase { [CommandParameter(1)] public bool IsActive; }
      public class Flag_Out_of_Zone : MiniStructureCommandBase { [CommandParameter(1)] public EnumObjectinitInit FlagOutOfZone; }
      public class Flag_Dead_or_Taken : MiniStructureCommandBase { [CommandParameter(1)] public EnumObjectinitInit FlagDeadOrTaken; }
      [UnusedByCPA] public class Special_Pos_Flag : MiniStructureCommandBase { [CommandParameter(1)] public string SpecialPosFlag; }
      public class Platform_Type : MiniStructureCommandBase { [CommandParameter(1)] public EnumPlatformType PlatformType; }
      [UnusedByCPA] public class Linked_To_Sector : MiniStructureCommandBase { [CommandParameter(1)] public string SectorName; }
      public class Traction_Factor : MiniStructureCommandBase { [CommandParameter(1)] public byte TractionFactor; }
      public class Actor_Capabilities : MiniStructureCommandBase { [CommandParameter(1)] public uint ActorCapabilities; }
      public class Transparency_Zone_Min : MiniStructureCommandBase { [CommandParameter(1)] public byte TransparencyZoneMin; }
      public class Transparency_Zone_Max : MiniStructureCommandBase { [CommandParameter(1)] public byte TransparencyZoneMax; }
      public class Too_Far_Limit : MiniStructureCommandBase { [CommandParameter(1)] public byte TooFarLimit; }

      public class CustomBitBase : MiniStructureCommandBase {[CommandParameter(1)] public bool Value; }
      public class InitialCustomBitBase : MiniStructureCommandBase {[CommandParameter(1)] public bool InitialValue; }
      
      public class CustomBit_1 : CustomBitBase {}
      public class CustomBit_2 : CustomBitBase {}
      public class CustomBit_3 : CustomBitBase {}
      public class CustomBit_4 : CustomBitBase {}
      public class CustomBit_5 : CustomBitBase {}
      public class CustomBit_6 : CustomBitBase {}
      public class CustomBit_7 : CustomBitBase {}
      public class CustomBit_8 : CustomBitBase {}
      public class CustomBit_9 : CustomBitBase {}
      public class CustomBit_10 : CustomBitBase {}
      public class CustomBit_11 : CustomBitBase {}
      public class CustomBit_12 : CustomBitBase {}
      public class CustomBit_13 : CustomBitBase {}
      public class CustomBit_14 : CustomBitBase {}
      public class CustomBit_15 : CustomBitBase {}
      public class CustomBit_16 : CustomBitBase {}
      public class CustomBit_17 : CustomBitBase {}
      public class CustomBit_18 : CustomBitBase {}
      public class CustomBit_19 : CustomBitBase {}
      public class CustomBit_20 : CustomBitBase {}
      public class CustomBit_21 : CustomBitBase {}
      public class CustomBit_22 : CustomBitBase {}
      public class CustomBit_23 : CustomBitBase {}
      public class CustomBit_24 : CustomBitBase {}
      public class CustomBit_25 : CustomBitBase {}
      public class CustomBit_26 : CustomBitBase {}
      public class CustomBit_27 : CustomBitBase {}
      public class CustomBit_28 : CustomBitBase {}
      public class CustomBit_29 : CustomBitBase {}
      public class CustomBit_30 : CustomBitBase {}
      public class CustomBit_31 : CustomBitBase {}
      public class CustomBit_32 : CustomBitBase {}

      public class Initial_CustomBit_1 : InitialCustomBitBase { }
      public class Initial_CustomBit_2 : InitialCustomBitBase { }
      public class Initial_CustomBit_3 : InitialCustomBitBase { }
      public class Initial_CustomBit_4 : InitialCustomBitBase { }
      public class Initial_CustomBit_5 : InitialCustomBitBase { }
      public class Initial_CustomBit_6 : InitialCustomBitBase { }
      public class Initial_CustomBit_7 : InitialCustomBitBase { }
      public class Initial_CustomBit_8 : InitialCustomBitBase { }
      public class Initial_CustomBit_9 : InitialCustomBitBase { }
      public class Initial_CustomBit_10 : InitialCustomBitBase { }
      public class Initial_CustomBit_11 : InitialCustomBitBase { }
      public class Initial_CustomBit_12 : InitialCustomBitBase { }
      public class Initial_CustomBit_13 : InitialCustomBitBase { }
      public class Initial_CustomBit_14 : InitialCustomBitBase { }
      public class Initial_CustomBit_15 : InitialCustomBitBase { }
      public class Initial_CustomBit_16 : InitialCustomBitBase { }
      public class Initial_CustomBit_17 : InitialCustomBitBase { }
      public class Initial_CustomBit_18 : InitialCustomBitBase { }
      public class Initial_CustomBit_19 : InitialCustomBitBase { }
      public class Initial_CustomBit_20 : InitialCustomBitBase { }
      public class Initial_CustomBit_21 : InitialCustomBitBase { }
      public class Initial_CustomBit_22 : InitialCustomBitBase { }
      public class Initial_CustomBit_23 : InitialCustomBitBase { }
      public class Initial_CustomBit_24 : InitialCustomBitBase { }
      public class Initial_CustomBit_25 : InitialCustomBitBase { }
      public class Initial_CustomBit_26 : InitialCustomBitBase { }
      public class Initial_CustomBit_27 : InitialCustomBitBase { }
      public class Initial_CustomBit_28 : InitialCustomBitBase { }
      public class Initial_CustomBit_29 : InitialCustomBitBase { }
      public class Initial_CustomBit_30 : InitialCustomBitBase { }
      public class Initial_CustomBit_31 : InitialCustomBitBase { }
      public class Initial_CustomBit_32 : InitialCustomBitBase { }
   }
}