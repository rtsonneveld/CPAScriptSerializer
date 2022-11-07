using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TSI.Sections;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSwitch {
   public class SoundInfoType : Command
   {
      [CommandParameter(0)]
      public CPAScriptReference<SIF_Type> SifType; // TODO: parse this (e.g. SIF_Type:Material)
   }
}
