using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Sections.ENL
{
   public class AddToNamesList : CreateNamesList
   {
      public AddToNamesList(string sectionId) : base(sectionId)
      {
      }
   }
}