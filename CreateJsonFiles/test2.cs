using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateJsonFiles
{
    public class ProductGroups
    {
        public List<Configurationx> ProductName { get; set; }
        //public List<Configurationx> inventoryManager { get; set; }
        //public List<Configurationx> salespadMobile { get; set; }
        //public List<Configurationx> shipCenter { get; set; }
    }

    public class Configurationx
    {
        public string ConfigurationName { get; set; }
        public List<string> Extended { get; set; }
        public List<string> Custom { get; set; }
        //public List<DLLGroupx> extended { get; set; }
        //public List<DLLGroupx> custom { get; set; }
    }

    //public class DLLGroupx
    //{
    //    public List<string> dllName { get; set; }
    //}
}
