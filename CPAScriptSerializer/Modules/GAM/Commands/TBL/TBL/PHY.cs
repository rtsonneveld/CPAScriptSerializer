using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.TBL {
   public class PHY : Command
   {
      [CommandParameter(0)] public CPAScriptReference<PO.Sections.PHY> PhysicalObjectReference;
   }
}
