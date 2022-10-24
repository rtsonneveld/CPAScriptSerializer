using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections.STA;
using CPAScriptSerializer.Modules.GMT.Sections;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR._3dData {
   public class ShadowMaterial : Command {
      [CommandParameter(0)]
      public CPAScriptReference<GameMaterial> Material;
   }
}
