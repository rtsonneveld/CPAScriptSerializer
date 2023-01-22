using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.GameData
{

    /// <summary>
    /// Class that acts as a container/context object for a single gamedata folder used by the CPA editor
    /// CPAScriptReferences have to be resolved using this object
    /// </summary>
    public class DataContext
    {
        public DataFolder Root = new DataFolder(null, null);

        public void LoadFromFolder(string gamedataFolder)
        {
            DataContext dataContext = new DataContext();
            //dataContext.Root.Load()
        }
    }
}
