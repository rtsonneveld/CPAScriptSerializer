using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {
   public class Camera {
      public class ShiftTarget : MiniStructureCommandVector {}
      public class ShiftTarget_Init : MiniStructureCommandVector {}
      public class ShiftPos : MiniStructureCommandVector { }
      public class ShiftPos_Init : MiniStructureCommandVector {}
      public class DistMin : MiniStructureCommandBase {[CommandParameter(1)] public float DistMinValue; }
      public class DistMin_Init : MiniStructureCommandBase {[CommandParameter(1)] public float DistMinInitValue; }
      public class DistMax : MiniStructureCommandBase {[CommandParameter(1)] public float DistMaxValue; }
      public class DistMax_Init : MiniStructureCommandBase {[CommandParameter(1)] public float DistMaxInitValue; }
      public class BoundDist_Min : MiniStructureCommandBase {[CommandParameter(1)] public float BoundDistMinValue; }
      public class BoundDistMin_Init : MiniStructureCommandBase {[CommandParameter(1)] public float BoundDistMinInitValue; }
      public class BoundDist_Max : MiniStructureCommandBase {[CommandParameter(1)] public float BoundDistMaxValue; }
      public class BoundDistMax_Init : MiniStructureCommandBase {[CommandParameter(1)] float BoundDistMaxInitValue; }
      public class Alpha : MiniStructureCommandBase {[CommandParameter(1)] public float AlphaValue; }
      public class Alpha_Init : MiniStructureCommandBase {[CommandParameter(1)] public float AlphaInitValue; }
      public class Shift_Alpha : MiniStructureCommandBase {[CommandParameter(1)] public float Shift_AlphaValue; }
      public class ShiftAlpha_Init : MiniStructureCommandBase {[CommandParameter(1)] public float ShiftAlphaInitValue; }
      public class Theta : MiniStructureCommandBase {[CommandParameter(1)] public float ThetaValue; }
      public class Theta_Init : MiniStructureCommandBase {[CommandParameter(1)] public float ThetaInitValue; }
      public class ShiftTheta : MiniStructureCommandBase {[CommandParameter(1)] public float ShiftThetaValue; }
      public class ShiftTheta_Init : MiniStructureCommandBase {[CommandParameter(1)] public float ShiftThetaInitValue; }
      public class LinearSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float LinearSpeedValue; }
      public class LinearSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float LinearSpeedInitValue; }
      public class LinearIncreaseSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float LinearIncreaseSpeedValue; }
      public class LinearIncreaseSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float LinearIncreaseSpeedInitValue; }
      public class LinearDecreaseSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float LinearDecreaseSpeedValue; }
      public class LinearDecreaseSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float LinearDecreaseSpeedInitValue; }
      public class AngularSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float AngularSpeedValue; }
      public class AngularSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float AngularSpeedInitValue; }
      public class AngularIncreaseSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float AngularIncreaseSpeedValue; }
      public class AngularIncreaseSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float AngularIncreaseSpeedInitValue; }
      public class AngularDecreaseSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float AngularDecreaseSpeedValue; }
      public class AngularDecreaseSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float AngularDecreaseSpeedInitValue; }
      public class TargetSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float TargetSpeedValue; }
      public class TargetSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float TargetSpeedInitValue; }
      public class TargetIncreaseSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float TargetIncreaseSpeedValue; }
      public class TargetIncreaseSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float TargetIncreaseSpeedInitValue; }
      public class TargetDecreaseSpeed : MiniStructureCommandBase {[CommandParameter(1)] public float TargetDecreaseSpeedValue; }
      public class TargetDecreaseSpeed_Init : MiniStructureCommandBase {[CommandParameter(1)] public float TargetDecreaseSpeedInitValue; }
      public class DNMFlags : MiniStructureCommandBase {[CommandParameter(1)] public int DNMFlagsValue; }
      public class DNMFlags_Init : MiniStructureCommandBase {[CommandParameter(1)] public int DNMFlagsInitValue; }
      public class IAFlags : MiniStructureCommandBase {[CommandParameter(1)] public int IAFlagsValue; }
      public class IAFlags_Init : MiniStructureCommandBase {[CommandParameter(1)] public int IAFlagsInitValue; }
      public class Focal : MiniStructureCommandBase {[CommandParameter(1)] public float FocalValue; }
      public class Focal_Init : MiniStructureCommandBase {[CommandParameter(1)] public float FocalInitValue; }
      public class ZMin : MiniStructureCommandBase {[CommandParameter(1)] public float ZMinValue; }
      public class ZMin_Init : MiniStructureCommandBase {[CommandParameter(1)] public float ZMinInitValue; }
      public class ZMax : MiniStructureCommandBase {[CommandParameter(1)] public float ZMaxValue; }
      public class ZMax_Init : MiniStructureCommandBase {[CommandParameter(1)] public float ZMaxInitValue; }
      public class Viewport_Type : MiniStructureCommandBase {[CommandParameter(1)] public string ViewportTypeValue; }
      public class ViewportType_Init : MiniStructureCommandBase {[CommandParameter(1)] public string ViewportTypeInitValue; }
      public class Channel : MiniStructureCommandBase {[CommandParameter(1)] public int ChannelValue; }
      public class Channel_Init : MiniStructureCommandBase {[CommandParameter(1)] public int ChannelInitValue; }
      public class IsActive : MiniStructureCommandBase {[CommandParameter(1)] public bool IsActiveValue; }
      public class IsActive_Init : MiniStructureCommandBase {[CommandParameter(1)] public bool IsActiveInitValue; }
   }
}
