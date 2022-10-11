using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SNA.Commands.PGB;

namespace CPAScriptSerializer.Modules.SNA.Sections {
   public class Vignette : CPAScriptSection {
      public Vignette(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(LoadLevelVignette), typeof(LoadLevelVignette)},
         {nameof(InitBarOutlineColor), typeof(InitBarOutlineColor)},
         {nameof(InitBarInsideColor), typeof(InitBarInsideColor)},
         {nameof(InitBarColor), typeof(InitBarColor)},
         {nameof(CreateBar), typeof(CreateBar)},
         {nameof(MaxValueBar), typeof(MaxValueBar)},
         {nameof(AddBar), typeof(AddBar)},
         {nameof(DisplayVignette), typeof(DisplayVignette)},
      };
   }
}
