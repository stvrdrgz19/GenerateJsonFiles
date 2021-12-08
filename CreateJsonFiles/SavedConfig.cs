using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateJsonFiles
{
    public class SavedConfig
    {
        public string Product { get; set; }
    }

    public class Products
    {
        public string ProductName { get; set; }
        public string Configurations {get; set; }
    }

    public class Configuration
    {
        public string ExtendedDLL { get; set; }
        public string CustomDLL { get; set; }
    }

    public class ExtendedDLLs
    {
        public List<string> DllNames { get; set; }
    }

    public class CustomDLLs
    {
        public List<string> DLLNames { get; set; }
    }
}
