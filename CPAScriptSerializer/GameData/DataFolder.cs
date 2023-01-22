using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CPAScriptSerializer.GameData {
   public class DataFolder
   {
      public DataFolder Parent;
      public readonly string Name;

      public DataFolder(DataFolder parent, string name)
      {
         Parent = parent;
         Name = name;
      }

      public Dictionary<string, DataFolder> Folders;
      public Dictionary<string, DataFile> Files;

      public void AddFile(DataFile file)
      {
         Files.Add(file.Name, file);
      }

      public void AddFolder(DataFolder folder)
      {
         Folders.Add(folder.Name, folder);
      }

      public DataFile GetFile(string name) => Files.TryGetValue(name, out var file) ? file : null;
      public DataFolder GetFolder(string name) => Folders.TryGetValue(name, out var folder) ? folder : null;

      public static void LoadFromDisk(string path, EnumFileReadMode readMode = EnumFileReadMode.AutoDetect)
      {
         var folders = Directory.GetDirectories(path);
         var files = Directory.GetFiles(path);

         foreach (var file in files) {
            DataFile.ReadFromDisk(file, readMode);
         }

         foreach (var folder in folders) {

         }
      }
   }
}
