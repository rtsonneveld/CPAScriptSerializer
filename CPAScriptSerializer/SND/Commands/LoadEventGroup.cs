﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   /*
    * Script Callback for SndEventGroupList section
    * Fills the event group "name <-> id"  conversion table from script
    */
   public class LoadEventGroup : Command
   {

      public string GroupName;
      public int GroupId;

      public override void Fill(Parameter[] parameters)
      {
         
      }
   }
}