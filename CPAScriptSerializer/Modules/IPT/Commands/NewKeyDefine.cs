using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands {
   public class NewKeyDefine : Command
   {
      /// <summary>
      /// If only Key is defined: use Key for both french and american keycodes
      /// If Key and FrenchKey is defined: use the french definition for both french and american keycodes
      /// Otherwise, french and american have their own definitions
      /// </summary>
      [CommandParameter(0)] public string Key;
      [CommandParameter(1)] public string FrenchKey;
      [CommandParameter(2)] public string AmericanKey;
   }
}
