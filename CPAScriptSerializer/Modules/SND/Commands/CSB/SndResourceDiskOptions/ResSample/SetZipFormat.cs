using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Enums;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetZipFormat : Command {
      [CommandParameter(0)]
      public EnumZipFormat ZipFormat;
   }
}
