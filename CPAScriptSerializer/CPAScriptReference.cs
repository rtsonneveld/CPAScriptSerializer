using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer {
   public class CPAScriptReference<T> where T:CPAScriptItem
   {
      public string Value;

      // TODO: parse references and allow them to be constructed/manipulated
      public CPAScriptReference(string s)
      {
         // Example: "rayman\YLT_RaymanModel\YLT_RaymanModel.rul^CreateIntelligence^CreateComport:KWN_Pousser_Attente"
         string[] splitParts = s.Split("^", 2);

         string filePath = splitParts[0]; // rayman\YLT_RaymanModel\YLT_RaymanModel.rul

         string[] secondPart = (splitParts.Length > 1 ? splitParts[1] : splitParts[0]).Split(":"); // CreateIntelligence^CreateComport:KWN_Pousser_Attente

         string pathToSection = secondPart[0]; // // secondPart = CreateIntelligence^CreateComport:KWN_Pousser_Attente

         string[] pathElements = pathToSection.Split("^");

         foreach (var sectionName in pathElements) {

         }

         Value = s;
      }

      public override string ToString()
      {
         return Value;
      }
   }
}
