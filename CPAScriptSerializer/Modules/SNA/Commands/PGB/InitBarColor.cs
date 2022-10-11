using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SNA.Commands.PGB {
   public class InitBarColor : Command
   {
      [CommandParameter(0)] public byte UpLeftRed;
      [CommandParameter(1)] public byte UpLeftGreen;
      [CommandParameter(2)] public byte UpLeftBlue;
      [CommandParameter(3)] public byte UpLeftAlpha;

      [CommandParameter(4)] public byte UpRightRed;
      [CommandParameter(5)] public byte UpRightGreen;
      [CommandParameter(6)] public byte UpRightBlue;
      [CommandParameter(7)] public byte UpRightAlpha;

      [CommandParameter(8)] public byte DownLeftRed;
      [CommandParameter(9)] public byte DownLeftGreen;
      [CommandParameter(10)] public byte DownLeftBlue;
      [CommandParameter(11)] public byte DownLeftAlpha;

      [CommandParameter(12)] public byte DownRightRed;
      [CommandParameter(13)] public byte DownRightGreen;
      [CommandParameter(14)] public byte DownRightBlue;
      [CommandParameter(15)] public byte DownRightAlpha;
   }
}
