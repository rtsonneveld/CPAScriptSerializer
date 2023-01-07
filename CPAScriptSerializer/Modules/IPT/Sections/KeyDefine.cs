using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.IPT.Commands;

namespace CPAScriptSerializer.Modules.IPT.Sections {
   
   public class KeyDefine : CPAScriptSection
   {
      [CommandParameter(0)]
      public int KeyMaxNumber;

      public KeyDefine(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(NewKeyDefine), typeof(NewKeyDefine) }
      };

      
   }
}
