using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TSI.Sections;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB {
   public class SoundInfoValue : Command
   {
      [CommandParameter(0)]
      public CPAScriptReference<SIF_Value> Value; // TODO: this reference has no filename specified but instead assumes <ProjectTitle>.sif as filename
   }
}
