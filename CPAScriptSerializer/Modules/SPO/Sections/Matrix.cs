using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SPO.Commands.Matrix;

namespace CPAScriptSerializer.Modules.SPO.Sections {
   public class Matrix : CPAScriptSection {
      public Matrix(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(MatrixTranslation), typeof(MatrixTranslation)},
         {nameof(MatrixRotation), typeof(MatrixRotation)},
         {nameof(MatrixScale), typeof(MatrixScale)},
      };
      
   }
}
