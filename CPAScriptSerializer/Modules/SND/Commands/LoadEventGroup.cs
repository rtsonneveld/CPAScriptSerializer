using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands {

   /*
    * Script Callback for SndEventGroupList section
    * Fills the event group "name <-> id"  conversion table from script
    */
   public class LoadEventGroup : Command
   {
      [CommandParameter(0)]
      public string GroupName;

      [CommandParameter(1)]
      public int GroupId;
   }
}
