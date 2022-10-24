using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands
{
   public class _3D_Data {

      [UnusedByCPA]
      public class Control_Translation : MiniStructureCommandVector { }

      public class Current_Action : MiniStructureCommandBase
      {
         [CommandParameter(1)] public string CurrentAction;
      }

      public class Initial_Action : MiniStructureCommandBase
      {
         [CommandParameter(1)] public string InitialAction;
      }

      public class Object_Table : MiniStructureCommandBase
      {
         [CommandParameter(1)] public string ObjectTable;
      }

      public class Object_Table_Init : MiniStructureCommandBase
      {
         [CommandParameter(1)] public string ObjectTableInit;
      }

      public class Current_Frame : MiniStructureCommandBase
      {
         [CommandParameter(1)] public int CurrentFrame;
      }

      public class Repeat_Anim : MiniStructureCommandBase
      {
         [CommandParameter(1)] public int RepeatAnim;
      }

      public class Next_Event : MiniStructureCommandBase
      {
         [CommandParameter(1)] public int NextEvent;
      }

      public class Draw_Mask : MiniStructureCommandBase
      {
         [CommandParameter(1)] public uint DrawMask;
      }

      public class Shadow_Scale_X : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShadowScaleX;
      }

      public class Shadow_Scale_Y : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShadowScaleY;
      }

      public class Shadow_Material : MiniStructureCommandBase
      {
         [CommandParameter(1, customDefaultValue: "No Material!")] public string ShadowMaterial;
      }

      public class Shadow_Quality : MiniStructureCommandBase
      {
         [CommandParameter(1)] public EnumShadowQuality ShadowQuality;
      }

      public class Shadow_Height : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float ShadowHeight;
      }

      /// <summary>
      /// Current Position
      /// </summary>
      public class Crt_Position : MiniStructureCommandBase
      {
         [CommandParameter(1)] public float PositionX;
         [CommandParameter(2)] public float PositionY;
         [CommandParameter(3)] public float PositionZ;
      }

      public class Brain_Computation_Frequency : MiniStructureCommandBase
      {
         [CommandParameter(1)] public int Frequency;
      }

      public class Light_Computation_Frequency : MiniStructureCommandBase
      {
         [CommandParameter(1)] public int Frequency;
      }

      [UnusedByCPA]
      public class Brain_Computation_Frequency_Init : MiniStructureCommandBase {
         [CommandParameter(1)] public int FrequencyInit;
      }

      [UnusedByCPA]
      public class Light_Computation_Frequency_Init : MiniStructureCommandBase {
         [CommandParameter(1)] public int FrequencyInit;
      }
   }

}