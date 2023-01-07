using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.TGM.Sections {
   public class Zone : CPAScriptSection {
      public Zone(string sectionId, string sectionType) : base(sectionId, sectionType)
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
         public ZDD(string sectionId, string sectionType) : base(sectionId, sectionType) { }
      };

      public class ZDE : Zone {
         public ZDE(string sectionId, string sectionType) : base(sectionId, sectionType) { }
      };

      public class ZDM : Zone {
         public ZDM(string sectionId, string sectionType) : base(sectionId, sectionType) { }
      };

      public class ZDR : Zone {
         public ZDR(string sectionId, string sectionType) : base(sectionId, sectionType) { }
      };
   }
}
