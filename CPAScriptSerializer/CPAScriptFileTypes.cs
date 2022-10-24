using System;
using System.Collections.Generic;
using System.IO;

namespace CPAScriptSerializer {
   public abstract partial class CPAScript {
      /// <summary>
      /// Dictionary that maps extension (lowercase) to a type of CPAScript
      /// </summary>
      public static Dictionary<string, Type> ExtensionToTypeMap = new Dictionary<string, Type>()
      {
         // Module AI
         { "ai",  typeof(Modules.AI.CPAScript_AI) },
         { "dec", typeof(Modules.AI.CPAScript_DEC) },
         { "mac", typeof(Modules.AI.CPAScript_MAC) },
         { "nod", typeof(Modules.AI.CPAScript_NOD) },
         { "rul", typeof(Modules.AI.CPAScript_RULRFX) },
         { "rfx", typeof(Modules.AI.CPAScript_RULRFX) },
         { "way", typeof(Modules.AI.CPAScript_WAY) },
         { "wp",  typeof(Modules.AI.CPAScript_WAY) },

         // Module GAM
         { "car", typeof(Modules.GAM.CPAScript_CAR) },
         { "chl", typeof(Modules.GAM.CPAScript_CHL) },
         { "lvl", typeof(Modules.GAM.CPAScript_LVL) },
         { "sta", typeof(Modules.GAM.CPAScript_STA) },
         { "tbl", typeof(Modules.GAM.CPAScript_TBL) },

         { "tbc", typeof(Modules.GAM.CPAScript_TBL) }, // Seemingly unused by CPA? Seems like it's the same format as .tbl files anyways
         { "tbo", typeof(Modules.GAM.CPAScript_TBL) }, // Seemingly unused by CPA? Seems like it's the same format as .tbl files anyways

         // Module GLI
         { "mod", typeof(Modules.GLI.CPAScript_MOD) },
         { "tex", typeof(Modules.GLI.CPAScript_TEX) },

         // Module GMT
         { "gmt", typeof(Modules.GMT.CPAScript_GMT) },
         { "vmt", typeof(Modules.GMT.CPAScript_VMT) },
         
         // Module ISI
         { "rli", typeof(Modules.ISI.CPAScript_RLI) },

         // Module IPT
         { "ipt", typeof(Modules.IPT.CPAScript_IPT) },

         // Module MEC
         { "mec", typeof(Modules.MEC.CPAScript_MEC) },

         // Module PO
         { "phy", typeof(Modules.PO.CPAScript_PHY) },
         { "vse", typeof(Modules.PO.CPAScript_VSE) },
         
         // Module SNA
         { "pgb", typeof(Modules.SNA.CPAScript_PGB) },

         // Module SND
         { "csb", typeof(Modules.SND.CPAScript_CSB) },
         { "lcb", typeof(Modules.SND.CPAScript_LCB) },

         // Module SPO
         { "spo", typeof(Modules.SPO.CPAScript_SPO) },
         
         // Module TAC
         { "ace", typeof(Modules.Editor.TAC.CPAScript_ACE)},
         { "acz", typeof(Modules.Editor.TAC.CPAScript_ACZ)},

         // Module TGM
         { "cmt", typeof(Modules.Editor.TGM.CPAScript_CMT)},
         { "ed.emc", typeof(Modules.Editor.TGM.CPAScript_ED_EMC)},

         // Module TIA
         { "emc", typeof(Modules.Editor.TIA.CPAScript_EMC)},
         { "tmc", typeof(Modules.Editor.TIA.CPAScript_EMC)},

         { "esb", typeof(Modules.Editor.TIA.CPAScript_ESB)},
         { "tsb", typeof(Modules.Editor.TIA.CPAScript_ESB)},

         { "ede", typeof(Modules.Editor.TIA.CPAScript_EDE)},
         { "tde", typeof(Modules.Editor.TIA.CPAScript_EDE)},

         { "eru", typeof(Modules.Editor.TIA.CPAScript_ERU)},
         { "tru", typeof(Modules.Editor.TIA.CPAScript_ERU)},

         { "erf", typeof(Modules.Editor.TIA.CPAScript_ERF)},
         { "trf", typeof(Modules.Editor.TIA.CPAScript_ERF)},

         // Module OZO
         { "bdv", typeof(Modules.Editor.OZO.CPAScript_BDV)},
         { "zoo", typeof(Modules.Editor.OZO.CPAScript_ZOO)},
         { "zdx", typeof(Modules.Editor.OZO.CPAScript_ZDX)},

         // Module oAC
         { "ema", typeof(Modules.Editor.OAC.CPAScript_EMA)},
      };

      public static CPAScript ReadFile(string path)
      {
         if (!File.Exists(path)) {
            throw new FileNotFoundException();
         }

         Type scriptType = null;

         // First check for exact file name matches

         string fileName = Path.GetFileName(path).ToLower();
         if (ExtensionToTypeMap.ContainsKey(fileName)) {

            scriptType = ExtensionToTypeMap[fileName];

         } else {
            string extension = Path.GetExtension(path).ToLower().Substring(1); // Without the dot
            if (!ExtensionToTypeMap.ContainsKey(extension)) {
               throw new NotSupportedException(
                  $"File extension .{extension} is not associated with any CPA script, or support hasn't been added yet!");
            }

            scriptType = ExtensionToTypeMap[extension];
         }

         CPAScript script = Activator.CreateInstance(scriptType) as CPAScript;
         if (script == null) {
            throw new Exception($"Could not create CPAScript for file {fileName}");
         }

         using (var stream = File.OpenRead(path)) {
            script.Read(stream);
         }

         return script;
      }

   }
}
