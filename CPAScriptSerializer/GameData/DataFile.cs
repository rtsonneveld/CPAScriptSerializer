using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CPAScriptSerializer.GameData {
   public abstract class DataFile {

      /// <summary>
      /// The full filename including extension. Be aware that this name will be used to save the file on the filesystem, so don't use any weird characters!
      /// </summary>
      public readonly string Name;

      protected DataFile(string name)
      {
         Name = name;
      }

      /// <summary>
      /// Reads a file from disk and returns either a BinaryFile or a ScriptFile, depending on the file extension
      /// </summary>
      /// <param name="path">Path to the file to be read</param>
      /// <param name="readMode">Whether to interpret the files as binary files, script files or both</param>
      /// <returns></returns>
      public static DataFile ReadFromDisk(string path, EnumFileReadMode readMode)
      {
         string fileName = Path.GetFileName(path);
         bool isBinaryFile = true;

         string extension = Path.GetExtension(path);
         if (extension.Length > 1) extension = extension.Substring(1);

         if (CPAScript.ExtensionToTypeMap.ContainsKey(extension) && readMode != EnumFileReadMode.ForceBinaryFiles) {
            isBinaryFile = false;
         }

         if (isBinaryFile) {
            if (readMode == EnumFileReadMode.ForceScriptFiles) {
               throw new Exception($"Cannot read {path} as a script file, the extension is not supported!");
            }

            return new BinaryFile(fileName, File.ReadAllBytes(path));
         }

         try {
            return new ScriptFile(fileName, CPAScript.ReadFile(path));
         } catch (NotSupportedException e) { }

         return null;
      }
   }
}
