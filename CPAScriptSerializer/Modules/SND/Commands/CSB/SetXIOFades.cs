using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB {
   public class SetXIOFades : Command
   {
      [CommandParameter(0)] public int CrossFade;
      [CommandParameter(0)] public int FadeIn;
      [CommandParameter(0)] public int FadeOut;
   }
}
