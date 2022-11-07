using CPAScriptSerializer.Modules.GAM.Sections.DSC;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_MEM : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(NewMemoryDescription), typeof(NewMemoryDescription) },
         { MemoryDescription.NewBinaryMemoryDescription, typeof(MemoryDescription) },
         { MemoryDescription.BinaryMemoryDescriptionPass1, typeof(MemoryDescription) },
         { MemoryDescription.BinaryMemoryDescriptionPass2, typeof(MemoryDescription) },
      };
   }
}
