using System.IO;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands.Logical {

   public class Or : LogicalCommand {

      public override int SubItemCount { get; } = 2;
   }
}
