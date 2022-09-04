using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResRandom {
   public class SetNothingCanBeChoosenTwice : Command {

      /// <summary>
      /// 'If FALSE, "nothing" element cannot be choosen twice consecutively.'
      /// </summary>
      [CommandParameter(0)] public bool NothingCanBeChoosenTwice;
   }
}
