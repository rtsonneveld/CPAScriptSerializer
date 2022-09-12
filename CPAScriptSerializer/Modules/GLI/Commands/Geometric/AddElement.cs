using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;
using CPAScriptSerializer.Modules.GLI.Sections;

namespace CPAScriptSerializer.Modules.GLI.Commands.Geometric
{
   public class AddElement : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public EnumElementType ElementType;
      [CommandParameter(2)] public CPAScriptReference<ElementSection> ElementSectionRef; // This can refer to any of the element types, so the reference has to be generic
   }
}