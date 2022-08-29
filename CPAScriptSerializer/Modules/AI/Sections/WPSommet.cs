using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Commands;

namespace CPAScriptSerializer.Modules.AI.Sections {

   public class WPSommet : CPAScriptSection {

      public WPSommet(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>() { };
      public override Type CommandTypeFallback => typeof(WpSommetWaypoint);
   }
}
