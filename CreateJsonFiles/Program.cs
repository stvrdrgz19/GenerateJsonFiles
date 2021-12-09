using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateJsonFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var saveConfig = new List<ProductGroups>()
            {
                new ProductGroups
                {
                    ProductName = new Configurationx
					{

					},
				}
            };


            //https://www.youtube.com/watch?v=LWtxg7g5s9U
            //https://www.c-sharpcorner.com/forums/cannot-implicitly-convert-systemcollectionsgenericlist-to




            //void GenerateEnvMgrSettingsFile()
            //{
            //    var envMgrLiteSettings = new EnvMgrLiteSettings
            //    {
            //        DatabaseBackupDirectory = @"C:\DatabaseBackups",
            //        SalesPadx86Directory = @"C:\Program Files (x86)\SalesPad.Desktop",
            //        SalesPadx64Directory = @"C:\Program Files\SalesPad.Desktop"
            //    };

            //    string output = JsonConvert.SerializeObject(envMgrLiteSettings, Formatting.Indented);
            //    File.WriteAllText(@"C:\Users\steve.rodriguez\Downloads\EnvMgrLite\Settings.json", output);
            //}

            //GenerateEnvMgrSettingsFile();

            //List<SavedConfig>

            //List<string> testExt = new List<string>();
            //testExt.Add("ext1");
            //testExt.Add("ext2");
            //testExt.Add("ext3");

            //List<string> testCust = new List<string>();
            //testCust.Add("cust1");
            //testCust.Add("cust2");
            //testCust.Add("cust3");

            //List<SavedConfig> savedConfigs = new List<SavedConfig>();


            ////https://bobnoordam.nl/csharp/converting-nested-objects-from-and-to-json-the-basics/
            //var saveConfig = new SavedConfig()
            //{
            //    Product = new Products()
            //    {
            //        ProductName = "SalesPad",
            //        Configurations = new Configuration()
            //        {
            //            ExtendedDLL = new ExtendedDLLs()
            //            {
            //                DllNames = testExt
            //            }
            //        }
            //    }
            //};
        }
    }
}
