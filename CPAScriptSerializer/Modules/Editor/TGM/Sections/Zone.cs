using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.TGM.Sections {
   public class Zone : CPAScriptSection {
      public Zone(string sectionId) : base(sectionId)
      {
      }
      
      // No commands in dictionary
      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>() { };

      public override Type CommandTypeFallback(string name)
      {
         return typeof(CollisionType);
      }

      public class ZDD : Zone
      {
         public ZDD(string sectionId) : base(sectionId) { }
      };

      public class ZDE : Zone {
         public ZDE(string sectionId) : base(sectionId) { }
      };

      public class ZDM : Zone {
         public ZDM(string sectionId) : base(sectionId) { }
      };

      public class ZDR : Zone {
         public ZDR(string sectionId) : base(sectionId) { }
      };
   }
}
