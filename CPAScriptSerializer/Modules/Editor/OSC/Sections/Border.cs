using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands.Generic;
using CPAScriptSerializer.Modules.Editor.OSC.Commands;

namespace CPAScriptSerializer.Modules.Editor.OSC.Sections {
   public class Border : CPAScriptSection
   {
      private const string MinPointOfBorder = "MinPointOfBorder";
      private const string MaxPointOfBorder = "MaxPointOfBorder";

      public Border(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {MinPointOfBorder, typeof(Vector3Command)},
         {MaxPointOfBorder, typeof(Vector3Command)},
      };
   }
}
