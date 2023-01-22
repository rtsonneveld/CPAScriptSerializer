using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dHIERARCHY {
   public class ChannelAndFather : Command
   {
      [CommandParameter(0)] public short Child;
      [CommandParameter(1)] public short Father;
   }
}
