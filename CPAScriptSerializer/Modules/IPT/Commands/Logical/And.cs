using System.IO;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands.Logical {

   public class And : LogicalCommand
   {
      public override int SubItemCount { get; } = 2;
   }
}
