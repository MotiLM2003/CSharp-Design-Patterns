using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DesignPatterns;

namespace SOLID_Design_Principles
{
    public class Persistence
    {

        public void SaveToFiles(Journal j, string filename, bool overwrite = false)
        {
            if(overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, j.ToString());
            }
        }
    }
}
