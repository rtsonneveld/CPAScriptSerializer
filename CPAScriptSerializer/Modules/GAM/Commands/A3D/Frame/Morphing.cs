using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Frame {
   public class Morphing : Command
   {
      [CommandParameter(0)] public short TargetObjectNumber;
      [CommandParameter(1)] public short Target;
      [CommandParameter(2)] public short MorphingAmount; // should be 0-255 but can be -1
      [CommandParameter(3)] public int Unknown; // TODO: figure out what this is
   }
}
