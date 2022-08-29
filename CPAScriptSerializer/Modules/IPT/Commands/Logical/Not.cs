using System.IO;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands.Logical
{
   public class Not : LogicalCommand
   {
      public override int SubItemCount { get; } = 1;
   }
}