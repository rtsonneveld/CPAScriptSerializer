namespace CPAScriptSerializer.Commands {

   public abstract class Command
   {
      public string Format;

      /// <summary>
      /// Implement this method where you parse each parameter and fill each field of your command object
      /// </summary>
      /// <param name="parameters">The list of parameters</param>
      public abstract void Fill(Parameter[] parameters);
   }
}
