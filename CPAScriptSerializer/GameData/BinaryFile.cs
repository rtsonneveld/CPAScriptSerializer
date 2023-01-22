using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.GameData {
   public class BinaryFile : DataFile {
      
      public readonly byte[] Contents;

      public BinaryFile(string name, byte[] contents) : base(name)
      {
         this.Contents = contents;
      }
   }
}
