using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.TBL {
   public class CustomZoom : Command
   {
      // Seems like only parameters 0, 4 and 8 are used, see TBL_fn_eScriptCallBackGeneral, 'if ( M_ActionIs( C_Entry_CustomZoom ) )'
      [CommandParameter(0)] public float ZoomX;
      [CommandParameter(4)] public float ZoomY;
      [CommandParameter(8)] public float ZoomZ;
   }
}
