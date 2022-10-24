using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Sections {
   public class MiniStructure : CPAScriptSection
   {
      [CommandParameter(0)] public EnumGroup Group;
      [CommandParameter(1)] public EnumAllocation Allocation;

      public MiniStructure(string sectionId) : base(sectionId) { }

      // Note: EditorActor MiniStructures are defined in EdActors_EditorActor::m_fn_vConstructListOfMS
      /*
       * 		Current_Action(Not_Linked,Wait)
		Initial_Action(Not_Linked,Wait)
		Object_Table(Not_Linked,"menumap.tbl")
		Object_Table_Init(Not_Linked,"menumap.tbl")
		Current_Frame(Not_Linked,0)
		Repeat_Anim(Not_Linked,0)
		Next_Event(Not_Linked,0)
		Draw_Mask(Not_Linked,4294967295)
		Shadow_Scale_X(Not_Linked,"1.000")
		Shadow_Scale_Y(Not_Linked,"1.000")
		Shadow_Material(Not_Linked,"No Material!")
		Shadow_Quality(Not_Linked,"Complete calculation")
		Shadow_Height(Not_Linked,"0.200")
		Crt_Position(Not_Linked,"0.000","0.000","0.000")
		Brain_Computation_Frequency(Not_Linked,1)
		Light_Computation_Frequency(Not_Linked,1)

       */

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         #region 3D_Data

         {nameof(_3D_Data.Control_Translation), typeof(_3D_Data.Control_Translation)},
         {nameof(_3D_Data.Current_Action), typeof(_3D_Data.Current_Action)},
         {nameof(_3D_Data.Initial_Action), typeof(_3D_Data.Initial_Action)},
         {nameof(_3D_Data.Object_Table), typeof(_3D_Data.Object_Table)},
         {nameof(_3D_Data.Object_Table_Init), typeof(_3D_Data.Object_Table_Init)},
         {nameof(_3D_Data.Current_Frame), typeof(_3D_Data.Current_Frame)},
         {nameof(_3D_Data.Repeat_Anim), typeof(_3D_Data.Repeat_Anim)},
         {nameof(_3D_Data.Next_Event), typeof(_3D_Data.Next_Event)},
         {nameof(_3D_Data.Draw_Mask), typeof(_3D_Data.Draw_Mask)},
         {nameof(_3D_Data.Shadow_Scale_X), typeof(_3D_Data.Shadow_Scale_X)},
         {nameof(_3D_Data.Shadow_Scale_Y), typeof(_3D_Data.Shadow_Scale_Y)},
         {nameof(_3D_Data.Shadow_Material), typeof(_3D_Data.Shadow_Material)},
         {nameof(_3D_Data.Shadow_Quality), typeof(_3D_Data.Shadow_Quality)},
         {nameof(_3D_Data.Shadow_Height), typeof(_3D_Data.Shadow_Height)},
         {nameof(_3D_Data.Crt_Position), typeof(_3D_Data.Crt_Position)},
         {nameof(_3D_Data.Brain_Computation_Frequency), typeof(_3D_Data.Brain_Computation_Frequency)},
         {nameof(_3D_Data.Brain_Computation_Frequency_Init), typeof(_3D_Data.Brain_Computation_Frequency_Init)},
         {nameof(_3D_Data.Light_Computation_Frequency), typeof(_3D_Data.Light_Computation_Frequency)},
         {nameof(_3D_Data.Light_Computation_Frequency_Init), typeof(_3D_Data.Light_Computation_Frequency_Init)},

         #endregion

         #region Brain

         {nameof(Brain.FastC_Run), typeof(Brain.FastC_Run)},
         {nameof(Brain.FastC_Index), typeof(Brain.FastC_Index)},

         #endregion

         #region Standard_Game

         {nameof(Standard_Game.Family_Type), typeof(Standard_Game.Family_Type)},
         {nameof(Standard_Game.Model_Type), typeof(Standard_Game.Model_Type)},
         {nameof(Standard_Game.Perso_Type), typeof(Standard_Game.Perso_Type)},
         {nameof(Standard_Game.Last_Trame), typeof(Standard_Game.Last_Trame)},
         {nameof(Standard_Game.Hit_Points), typeof(Standard_Game.Hit_Points)},
         {nameof(Standard_Game.Initial_Hit_Points), typeof(Standard_Game.Initial_Hit_Points)},
         {nameof(Standard_Game.Hit_Points_Max), typeof(Standard_Game.Hit_Points_Max)},
         {nameof(Standard_Game.Initial_Hit_Points_Max), typeof(Standard_Game.Initial_Hit_Points_Max)},
         {nameof(Standard_Game.Hit_Points_Max_Max), typeof(Standard_Game.Hit_Points_Max_Max)},
         {nameof(Standard_Game.Desactivate_At_All), typeof(Standard_Game.Desactivate_At_All)},
         {nameof(Standard_Game.Activable), typeof(Standard_Game.Activable)},
         {nameof(Standard_Game.Active), typeof(Standard_Game.Active)},
         {nameof(Standard_Game.Flag_Out_of_Zone), typeof(Standard_Game.Flag_Out_of_Zone)},
         {nameof(Standard_Game.Flag_Dead_or_Taken), typeof(Standard_Game.Flag_Dead_or_Taken)},
         {nameof(Standard_Game.Special_Pos_Flag), typeof(Standard_Game.Special_Pos_Flag)}, // Unused
         {nameof(Standard_Game.Platform_Type), typeof(Standard_Game.Platform_Type)},
         {nameof(Standard_Game.Linked_To_Sector), typeof(Standard_Game.Linked_To_Sector)}, // Unused
         {nameof(Standard_Game.Traction_Factor), typeof(Standard_Game.Traction_Factor)},
         {nameof(Standard_Game.Actor_Capabilities), typeof(Standard_Game.Actor_Capabilities)},
         {nameof(Standard_Game.Transparency_Zone_Min), typeof(Standard_Game.Transparency_Zone_Min)},
         {nameof(Standard_Game.Transparency_Zone_Max), typeof(Standard_Game.Transparency_Zone_Max)},
         {nameof(Standard_Game.Too_Far_Limit), typeof(Standard_Game.Too_Far_Limit)},

         #region Standard_Game.CustomBit_1-32
         {nameof(Standard_Game.CustomBit_1), typeof(Standard_Game.CustomBit_1)},
         {nameof(Standard_Game.CustomBit_2), typeof(Standard_Game.CustomBit_2)},
         {nameof(Standard_Game.CustomBit_3), typeof(Standard_Game.CustomBit_3)},
         {nameof(Standard_Game.CustomBit_4), typeof(Standard_Game.CustomBit_4)},
         {nameof(Standard_Game.CustomBit_5), typeof(Standard_Game.CustomBit_5)},
         {nameof(Standard_Game.CustomBit_6), typeof(Standard_Game.CustomBit_6)},
         {nameof(Standard_Game.CustomBit_7), typeof(Standard_Game.CustomBit_7)},
         {nameof(Standard_Game.CustomBit_8), typeof(Standard_Game.CustomBit_8)},
         {nameof(Standard_Game.CustomBit_9), typeof(Standard_Game.CustomBit_9)},
         {nameof(Standard_Game.CustomBit_10), typeof(Standard_Game.CustomBit_10)},
         {nameof(Standard_Game.CustomBit_11), typeof(Standard_Game.CustomBit_11)},
         {nameof(Standard_Game.CustomBit_12), typeof(Standard_Game.CustomBit_12)},
         {nameof(Standard_Game.CustomBit_13), typeof(Standard_Game.CustomBit_13)},
         {nameof(Standard_Game.CustomBit_14), typeof(Standard_Game.CustomBit_14)},
         {nameof(Standard_Game.CustomBit_15), typeof(Standard_Game.CustomBit_15)},
         {nameof(Standard_Game.CustomBit_16), typeof(Standard_Game.CustomBit_16)},
         {nameof(Standard_Game.CustomBit_17), typeof(Standard_Game.CustomBit_17)},
         {nameof(Standard_Game.CustomBit_18), typeof(Standard_Game.CustomBit_18)},
         {nameof(Standard_Game.CustomBit_19), typeof(Standard_Game.CustomBit_19)},
         {nameof(Standard_Game.CustomBit_20), typeof(Standard_Game.CustomBit_20)},
         {nameof(Standard_Game.CustomBit_21), typeof(Standard_Game.CustomBit_21)},
         {nameof(Standard_Game.CustomBit_22), typeof(Standard_Game.CustomBit_22)},
         {nameof(Standard_Game.CustomBit_23), typeof(Standard_Game.CustomBit_23)},
         {nameof(Standard_Game.CustomBit_24), typeof(Standard_Game.CustomBit_24)},
         {nameof(Standard_Game.CustomBit_25), typeof(Standard_Game.CustomBit_25)},
         {nameof(Standard_Game.CustomBit_26), typeof(Standard_Game.CustomBit_26)},
         {nameof(Standard_Game.CustomBit_27), typeof(Standard_Game.CustomBit_27)},
         {nameof(Standard_Game.CustomBit_28), typeof(Standard_Game.CustomBit_28)},
         {nameof(Standard_Game.CustomBit_29), typeof(Standard_Game.CustomBit_29)},
         {nameof(Standard_Game.CustomBit_30), typeof(Standard_Game.CustomBit_30)},
         {nameof(Standard_Game.CustomBit_31), typeof(Standard_Game.CustomBit_31)},
         {nameof(Standard_Game.CustomBit_32), typeof(Standard_Game.CustomBit_32)},
         #endregion

         #region Standard_Game.Initial_CustomBit_1-32
         {nameof(Standard_Game.Initial_CustomBit_1), typeof(Standard_Game.Initial_CustomBit_1)},
         {nameof(Standard_Game.Initial_CustomBit_2), typeof(Standard_Game.Initial_CustomBit_2)},
         {nameof(Standard_Game.Initial_CustomBit_3), typeof(Standard_Game.Initial_CustomBit_3)},
         {nameof(Standard_Game.Initial_CustomBit_4), typeof(Standard_Game.Initial_CustomBit_4)},
         {nameof(Standard_Game.Initial_CustomBit_5), typeof(Standard_Game.Initial_CustomBit_5)},
         {nameof(Standard_Game.Initial_CustomBit_6), typeof(Standard_Game.Initial_CustomBit_6)},
         {nameof(Standard_Game.Initial_CustomBit_7), typeof(Standard_Game.Initial_CustomBit_7)},
         {nameof(Standard_Game.Initial_CustomBit_8), typeof(Standard_Game.Initial_CustomBit_8)},
         {nameof(Standard_Game.Initial_CustomBit_9), typeof(Standard_Game.Initial_CustomBit_9)},
         {nameof(Standard_Game.Initial_CustomBit_10), typeof(Standard_Game.Initial_CustomBit_10)},
         {nameof(Standard_Game.Initial_CustomBit_11), typeof(Standard_Game.Initial_CustomBit_11)},
         {nameof(Standard_Game.Initial_CustomBit_12), typeof(Standard_Game.Initial_CustomBit_12)},
         {nameof(Standard_Game.Initial_CustomBit_13), typeof(Standard_Game.Initial_CustomBit_13)},
         {nameof(Standard_Game.Initial_CustomBit_14), typeof(Standard_Game.Initial_CustomBit_14)},
         {nameof(Standard_Game.Initial_CustomBit_15), typeof(Standard_Game.Initial_CustomBit_15)},
         {nameof(Standard_Game.Initial_CustomBit_16), typeof(Standard_Game.Initial_CustomBit_16)},
         {nameof(Standard_Game.Initial_CustomBit_17), typeof(Standard_Game.Initial_CustomBit_17)},
         {nameof(Standard_Game.Initial_CustomBit_18), typeof(Standard_Game.Initial_CustomBit_18)},
         {nameof(Standard_Game.Initial_CustomBit_19), typeof(Standard_Game.Initial_CustomBit_19)},
         {nameof(Standard_Game.Initial_CustomBit_20), typeof(Standard_Game.Initial_CustomBit_20)},
         {nameof(Standard_Game.Initial_CustomBit_21), typeof(Standard_Game.Initial_CustomBit_21)},
         {nameof(Standard_Game.Initial_CustomBit_22), typeof(Standard_Game.Initial_CustomBit_22)},
         {nameof(Standard_Game.Initial_CustomBit_23), typeof(Standard_Game.Initial_CustomBit_23)},
         {nameof(Standard_Game.Initial_CustomBit_24), typeof(Standard_Game.Initial_CustomBit_24)},
         {nameof(Standard_Game.Initial_CustomBit_25), typeof(Standard_Game.Initial_CustomBit_25)},
         {nameof(Standard_Game.Initial_CustomBit_26), typeof(Standard_Game.Initial_CustomBit_26)},
         {nameof(Standard_Game.Initial_CustomBit_27), typeof(Standard_Game.Initial_CustomBit_27)},
         {nameof(Standard_Game.Initial_CustomBit_28), typeof(Standard_Game.Initial_CustomBit_28)},
         {nameof(Standard_Game.Initial_CustomBit_29), typeof(Standard_Game.Initial_CustomBit_29)},
         {nameof(Standard_Game.Initial_CustomBit_30), typeof(Standard_Game.Initial_CustomBit_30)},
         {nameof(Standard_Game.Initial_CustomBit_31), typeof(Standard_Game.Initial_CustomBit_31)},
         {nameof(Standard_Game.Initial_CustomBit_32), typeof(Standard_Game.Initial_CustomBit_32)},
         #endregion

         #endregion

         #region Anim_Effect

         {nameof(Anim_Effect.Shift_Phase), typeof(Anim_Effect.Shift_Phase)},
         {nameof(Anim_Effect.Shift_Max), typeof(Anim_Effect.Shift_Max)},
         {nameof(Anim_Effect.Shift_Plus), typeof(Anim_Effect.Shift_Plus)},

         #endregion

         #region Sect_Info

         {nameof(Sect_Info.Current_Sector), typeof(Sect_Info.Current_Sector)},
         {nameof(Sect_Info.Previous_Sector), typeof(Sect_Info.Previous_Sector)},

         #endregion

         #region Light

         {nameof(Light.Light_Type), typeof(Light.Light_Type)},
         {nameof(Light.LocalLight), typeof(Light.LocalLight)},
         {nameof(Light.LocalLight_Init), typeof(Light.LocalLight_Init)},
         {nameof(Light.OnlyLocalLight), typeof(Light.OnlyLocalLight)},
         {nameof(Light.OnlyLocalLight_Init), typeof(Light.OnlyLocalLight_Init)},
         {nameof(Light.Girophare), typeof(Light.Girophare)},
         {nameof(Light.Girophare_Init), typeof(Light.Girophare_Init)},
         {nameof(Light.Pulsing), typeof(Light.Pulsing)},
         {nameof(Light.Pulsing_Init), typeof(Light.Pulsing_Init)},
         {nameof(Light.Offset_Vector), typeof(Light.Offset_Vector)},
         {nameof(Light.Offset_Vector_Init), typeof(Light.Offset_Vector_Init)},
         {nameof(Light.Angle_Vector), typeof(Light.Angle_Vector)},
         {nameof(Light.Angle_Vector_Init), typeof(Light.Angle_Vector_Init)},
         {nameof(Light.Step_Giro), typeof(Light.Step_Giro)},
         {nameof(Light.Step_Giro_Init), typeof(Light.Step_Giro_Init)},
         {nameof(Light.Step_Pulse), typeof(Light.Step_Pulse)},
         {nameof(Light.Step_Pulse_Init), typeof(Light.Step_Pulse_Init)},
         {nameof(Light.Max_Range_Pulse), typeof(Light.Max_Range_Pulse)},
         {nameof(Light.Max_Range_Pulse_Init), typeof(Light.Max_Range_Pulse_Init)},
         {nameof(Light.Angle_Giro), typeof(Light.Angle_Giro)},
         {nameof(Light.Angle_Giro_Init), typeof(Light.Angle_Giro_Init)},
         {nameof(Light.OnOff_Init), typeof(Light.OnOff_Init)},
         {nameof(Light.Init_Color_R), typeof(Light.Init_Color_R)},
         {nameof(Light.Init_Color_G), typeof(Light.Init_Color_G)},
         {nameof(Light.Init_Color_B), typeof(Light.Init_Color_B)},
         {nameof(Light.Near_Init), typeof(Light.Near_Init)},
         {nameof(Light.Far_Init), typeof(Light.Far_Init)},
         {nameof(Light.Little_Alpha_Init), typeof(Light.Little_Alpha_Init)},
         {nameof(Light.Big_Alpha_Init), typeof(Light.Big_Alpha_Init)},
         {nameof(Light.Little_Tangent_Init), typeof(Light.Little_Tangent_Init)},
         {nameof(Light.Big_Tangent_Init), typeof(Light.Big_Tangent_Init)},
         {nameof(Light.Min_Internal_Pos_Init), typeof(Light.Min_Internal_Pos_Init)},
         {nameof(Light.Max_Internal_Pos_Init), typeof(Light.Max_Internal_Pos_Init)},
         {nameof(Light.Min_External_Pos_Init), typeof(Light.Min_External_Pos_Init)},
         {nameof(Light.Max_External_Pos_Init), typeof(Light.Max_External_Pos_Init)},
         {nameof(Light.Intensity_Min_Init), typeof(Light.Intensity_Min_Init)},
         {nameof(Light.Intensity_Max_Init), typeof(Light.Intensity_Max_Init)},

         #endregion

         #region Ways
         
         {nameof(Ways.Reseau), typeof(Ways.Reseau)},
         {nameof(Ways.Index), typeof(Ways.Index)},
         {nameof(Ways.Circulaire), typeof(Ways.Circulaire)},
         {nameof(Ways.Way), typeof(Ways.Way)}, // unused

         #endregion

         #region World
         
         {nameof(World.Snow_Force), typeof(World.Snow_Force)},
         {nameof(World.Snow_Force_Init), typeof(World.Snow_Force_Init)},
         {nameof(World.Rain_Force), typeof(World.Rain_Force)},
         {nameof(World.Rain_Force_Init), typeof(World.Rain_Force_Init)},
         {nameof(World.Wind_Vector), typeof(World.Wind_Vector)},
         {nameof(World.Wind_Vector_Init), typeof(World.Wind_Vector_Init)},

         #endregion

         #region Dynamics
         
         {nameof(Dynamics.Size), typeof(Dynamics.Size)},
         {nameof(Dynamics.Collision), typeof(Dynamics.Collision)},
         {nameof(Dynamics.Slide_x), typeof(Dynamics.Slide_x)},
         {nameof(Dynamics.Slide_y), typeof(Dynamics.Slide_y)},
         {nameof(Dynamics.Slide_z), typeof(Dynamics.Slide_z)},

         #endregion

         #region Sound
         
         {nameof(Sound.Satur_Distance), typeof(Sound.Satur_Distance)},
         {nameof(Sound.Satur_Distance_Init), typeof(Sound.Satur_Distance_Init)},
         {nameof(Sound.BackGround_Distance), typeof(Sound.BackGround_Distance)},
         {nameof(Sound.BackGround_Distance_Init), typeof(Sound.BackGround_Distance_Init)},

         #endregion

         #region Camera

         {nameof(Camera.ShiftTarget), typeof(Camera.ShiftTarget)},
         {nameof(Camera.ShiftTarget_Init), typeof(Camera.ShiftTarget_Init)},
         {nameof(Camera.ShiftPos), typeof(Camera.ShiftPos)},
         {nameof(Camera.ShiftPos_Init), typeof(Camera.ShiftPos_Init)},
         {nameof(Camera.DistMin), typeof(Camera.DistMin)},
         {nameof(Camera.DistMin_Init), typeof(Camera.DistMin_Init)},
         {nameof(Camera.DistMax), typeof(Camera.DistMax)},
         {nameof(Camera.DistMax_Init), typeof(Camera.DistMax_Init)},
         {nameof(Camera.BoundDist_Min), typeof(Camera.BoundDist_Min)},
         {nameof(Camera.BoundDistMin_Init), typeof(Camera.BoundDistMin_Init)},
         {nameof(Camera.BoundDist_Max), typeof(Camera.BoundDist_Max)},
         {nameof(Camera.BoundDistMax_Init), typeof(Camera.BoundDistMax_Init)},
         {nameof(Camera.Alpha), typeof(Camera.Alpha)},
         {nameof(Camera.Alpha_Init), typeof(Camera.Alpha_Init)},
         {nameof(Camera.Shift_Alpha), typeof(Camera.Shift_Alpha)},
         {nameof(Camera.ShiftAlpha_Init), typeof(Camera.ShiftAlpha_Init)},
         {nameof(Camera.Theta), typeof(Camera.Theta)},
         {nameof(Camera.Theta_Init), typeof(Camera.Theta_Init)},
         {nameof(Camera.ShiftTheta), typeof(Camera.ShiftTheta)},
         {nameof(Camera.ShiftTheta_Init), typeof(Camera.ShiftTheta_Init)},
         {nameof(Camera.LinearSpeed), typeof(Camera.LinearSpeed)},
         {nameof(Camera.LinearSpeed_Init), typeof(Camera.LinearSpeed_Init)},
         {nameof(Camera.LinearIncreaseSpeed), typeof(Camera.LinearIncreaseSpeed)},
         {nameof(Camera.LinearIncreaseSpeed_Init), typeof(Camera.LinearIncreaseSpeed_Init)},
         {nameof(Camera.LinearDecreaseSpeed), typeof(Camera.LinearDecreaseSpeed)},
         {nameof(Camera.LinearDecreaseSpeed_Init), typeof(Camera.LinearDecreaseSpeed_Init)},
         {nameof(Camera.AngularSpeed), typeof(Camera.AngularSpeed)},
         {nameof(Camera.AngularSpeed_Init), typeof(Camera.AngularSpeed_Init)},
         {nameof(Camera.AngularIncreaseSpeed), typeof(Camera.AngularIncreaseSpeed)},
         {nameof(Camera.AngularIncreaseSpeed_Init), typeof(Camera.AngularIncreaseSpeed_Init)},
         {nameof(Camera.AngularDecreaseSpeed), typeof(Camera.AngularDecreaseSpeed)},
         {nameof(Camera.AngularDecreaseSpeed_Init), typeof(Camera.AngularDecreaseSpeed_Init)},
         {nameof(Camera.TargetSpeed), typeof(Camera.TargetSpeed)},
         {nameof(Camera.TargetSpeed_Init), typeof(Camera.TargetSpeed_Init)},
         {nameof(Camera.TargetIncreaseSpeed), typeof(Camera.TargetIncreaseSpeed)},
         {nameof(Camera.TargetIncreaseSpeed_Init), typeof(Camera.TargetIncreaseSpeed_Init)},
         {nameof(Camera.TargetDecreaseSpeed), typeof(Camera.TargetDecreaseSpeed)},
         {nameof(Camera.TargetDecreaseSpeed_Init), typeof(Camera.TargetDecreaseSpeed_Init)},
         {nameof(Camera.DNMFlags), typeof(Camera.DNMFlags)},
         {nameof(Camera.DNMFlags_Init), typeof(Camera.DNMFlags_Init)},
         {nameof(Camera.IAFlags), typeof(Camera.IAFlags)},
         {nameof(Camera.IAFlags_Init), typeof(Camera.IAFlags_Init)},
         {nameof(Camera.Focal), typeof(Camera.Focal)},
         {nameof(Camera.Focal_Init), typeof(Camera.Focal_Init)},
         {nameof(Camera.ZMin), typeof(Camera.ZMin)},
         {nameof(Camera.ZMin_Init), typeof(Camera.ZMin_Init)},
         {nameof(Camera.ZMax), typeof(Camera.ZMax)},
         {nameof(Camera.ZMax_Init), typeof(Camera.ZMax_Init)},
         {nameof(Camera.Viewport_Type), typeof(Camera.Viewport_Type)},
         {nameof(Camera.ViewportType_Init), typeof(Camera.ViewportType_Init)},
         {nameof(Camera.Channel), typeof(Camera.Channel)},
         {nameof(Camera.Channel_Init), typeof(Camera.Channel_Init)},
         {nameof(Camera.IsActive), typeof(Camera.IsActive)},
         {nameof(Camera.IsActive_Init), typeof(Camera.IsActive_Init)},

         #endregion

         #region Micro

         {nameof(Micro.Is_Active), typeof(Micro.Is_Active)},

         #endregion

         #region CollisionSet

         {nameof(CollisionSet.Character_Priority), typeof(CollisionSet.Character_Priority)},
         {nameof(CollisionSet.Collision_Flag), typeof(CollisionSet.Collision_Flag)},
         {nameof(CollisionSet.No_Collision_With_Map), typeof(CollisionSet.No_Collision_With_Map)},
         {nameof(CollisionSet.No_Collision_With_Map_Init), typeof(CollisionSet.No_Collision_With_Map_Init)},
         {nameof(CollisionSet.No_Collision_With_Projectile), typeof(CollisionSet.No_Collision_With_Projectile)},
         {nameof(CollisionSet.No_Collision_With_Projectile_Init), typeof(CollisionSet.No_Collision_With_Projectile_Init)},
         {nameof(CollisionSet.No_Collision_With_Secondary_Character), typeof(CollisionSet.No_Collision_With_Secondary_Character)},
         {nameof(CollisionSet.No_Collision_With_Secondary_Character_Init), typeof(CollisionSet.No_Collision_With_Secondary_Character_Init)},
         {nameof(CollisionSet.No_Collision_With_Main_Character), typeof(CollisionSet.No_Collision_With_Main_Character)},
         {nameof(CollisionSet.No_Collision_With_Main_Character_Init), typeof(CollisionSet.No_Collision_With_Main_Character_Init)},
         {nameof(CollisionSet.Force_Collision_When_Not_Moving), typeof(CollisionSet.Force_Collision_When_Not_Moving)},
         {nameof(CollisionSet.Force_Collision_When_Not_Moving_Init), typeof(CollisionSet.Force_Collision_When_Not_Moving_Init)},
         {nameof(CollisionSet.No_Collision_With_Other_Sectors), typeof(CollisionSet.No_Collision_With_Other_Sectors)},
         {nameof(CollisionSet.No_Collision_With_Other_Sectors_Init), typeof(CollisionSet.No_Collision_With_Other_Sectors_Init)},
         {nameof(CollisionSet.No_Collision_Zde_With_Projectile), typeof(CollisionSet.No_Collision_Zde_With_Projectile)},
         {nameof(CollisionSet.No_Collision_Zde_With_Projectile_Init), typeof(CollisionSet.No_Collision_Zde_With_Projectile_Init)},
         {nameof(CollisionSet.Collision_Frequency), typeof(CollisionSet.Collision_Frequency)},
         {nameof(CollisionSet.Collision_Frequency_Init), typeof(CollisionSet.Collision_Frequency_Init)},
         {nameof(CollisionSet.ZDE), typeof(CollisionSet.ZDE)},
         {nameof(CollisionSet.ZDM), typeof(CollisionSet.ZDM)},
         {nameof(CollisionSet.ZDD), typeof(CollisionSet.ZDD)},
         {nameof(CollisionSet.ZDR), typeof(CollisionSet.ZDR)},

         #endregion
      };
   }
}
