using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {

   public class Light
   {
      public class Light_Type : MiniStructureCommandBase {[CommandParameter(1)] public EnumLightType LightType; }
      public class LocalLight : MiniStructureCommandBase {[CommandParameter(1)] public bool LocalLightValue; }
      public class LocalLight_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool LocalLightInit; }
      public class OnlyLocalLight : MiniStructureCommandBase {[CommandParameter(1)] public bool OnlyLocalLightValue; }
      public class OnlyLocalLight_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool OnlyLocalLightInit; }
      public class Girophare : MiniStructureCommandBase {[CommandParameter(1)] public bool GirophareValue; }
      public class Girophare_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool GirophareInit; }
      public class Pulsing : MiniStructureCommandBase {[CommandParameter(1)] public bool PulsingValue; }
      public class Pulsing_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool PulsingInit; }

      public class Offset_Vector : MiniStructureCommandVector { }
      public class Offset_Vector_Init : MiniStructureCommandVector { }
      public class Angle_Vector : MiniStructureCommandVector { }
      public class Angle_Vector_Init : MiniStructureCommandVector { }

      public class Step_Giro : MiniStructureCommandBase {[CommandParameter(1)] public float StepGiro; }
      public class Step_Giro_Init : MiniStructureCommandBase {[CommandParameter(1)] public float StepGiroInit; }
      public class Step_Pulse : MiniStructureCommandBase {[CommandParameter(1)] public float StepPulse; }
      public class Step_Pulse_Init : MiniStructureCommandBase {[CommandParameter(1)] public float StepPulseInit; }
      public class Max_Range_Pulse : MiniStructureCommandBase {[CommandParameter(1)] public float MaxRangePulse; }
      public class Max_Range_Pulse_Init : MiniStructureCommandBase {[CommandParameter(1)] public float MaxRangePulseInit; }
      public class Angle_Giro : MiniStructureCommandBase {[CommandParameter(1)] public float AngleGiro; }
      public class Angle_Giro_Init : MiniStructureCommandBase {[CommandParameter(1)] public float AngleGiroInit; }
      public class OnOff_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool OnOffInit; }
      public class Init_Color_R : MiniStructureCommandBase {[CommandParameter(1)] public float InitColorR; }
      public class Init_Color_G : MiniStructureCommandBase {[CommandParameter(1)] public float InitColorG; }
      public class Init_Color_B : MiniStructureCommandBase {[CommandParameter(1)] public float InitColorB; }
      public class Near_Init : MiniStructureCommandBase {[CommandParameter(1)] public float NearInit; }
      public class Far_Init : MiniStructureCommandBase {[CommandParameter(1)] public float FarInit; }
      public class Little_Alpha_Init : MiniStructureCommandBase {[CommandParameter(1)] public float LittleAlphaInit; }
      public class Big_Alpha_Init : MiniStructureCommandBase {[CommandParameter(1)] public float BigAlphaInit; }
      public class Little_Tangent_Init : MiniStructureCommandBase {[CommandParameter(1)] public float LittleTangentInit; }
      public class Big_Tangent_Init : MiniStructureCommandBase {[CommandParameter(1)] public float BigTangentInit; }

      public class Min_Internal_Pos_Init : MiniStructureCommandVector { }
      public class Max_Internal_Pos_Init : MiniStructureCommandVector { }
      public class Min_External_Pos_Init : MiniStructureCommandVector { }
      public class Max_External_Pos_Init : MiniStructureCommandVector { }
      public class Intensity_Min_Init : MiniStructureCommandBase {[CommandParameter(1)] public float IntensityMinInit; }
      public class Intensity_Max_Init : MiniStructureCommandBase {[CommandParameter(1)] public float IntensityMaxInit; }
   }
}
