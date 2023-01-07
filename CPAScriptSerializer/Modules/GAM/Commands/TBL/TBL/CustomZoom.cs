using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.TBL {
   public class CustomZoom : Command
   {
      // Seems like only parameters 0, 4 and 8 are used, see TBL_fn_eScriptCallBackGeneral, 'if ( M_ActionIs( C_Entry_CustomZoom ) )'
      [CommandParameter(0)] public float ZoomX;

      [CommandParameter(1)] public float Unused1;
      [CommandParameter(2)] public float Unused2;
      [CommandParameter(3)] public float Unused3;

      [CommandParameter(4)] public float ZoomY;

      [CommandParameter(5)] public float Unused5;
      [CommandParameter(6)] public float Unused6;
      [CommandParameter(7)] public float Unused7;

      [CommandParameter(8)] public float ZoomZ;
   }
}
