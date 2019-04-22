using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCThreading.Libraries.BusinessRules.Queries
{
    public class RealFiles
    {
        string folder;

        public RealFiles(string route)
        {
            folder = route;
        }

        public string[] getAllrealFiles()
        {
            string[] files = Directory.GetFiles(folder, "*.*");

            return files;
        }

        public bool createNewFile(string[] listado, string fileName)
        {
            try
            {
                File.WriteAllLines(folder+fileName, listado);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
