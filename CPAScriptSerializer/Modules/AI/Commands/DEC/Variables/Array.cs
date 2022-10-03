using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public abstract class Array : VariableBase
   {
      [CommandParameter(2)] public int Size;
   }

   public class IntegerArray : Array { }
   public class FloatArray : Array { }
   public class WayPointArray : Array { }
   public class TextArray : Array { }
   public class VectorArray : Array { }
   public class PersoArray : Array { }
}
