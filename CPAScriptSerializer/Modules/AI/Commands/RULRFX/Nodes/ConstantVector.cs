using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   // TODO: afaik this is never used, maybe used in older games?
   [UnusedByCPA]
   public class ConstantVector : Command
   {
      [CommandParameter(0)] public float ValueX;
      [CommandParameter(1)] public float ValueY;
      [CommandParameter(2)] public float ValueZ;
      [CommandParameter(3)] public byte Depth;
   }
}