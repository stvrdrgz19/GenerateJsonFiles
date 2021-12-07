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
            void GenerateEnvMgrSettingsFile()
            {
                var envMgrLiteSettings = new EnvMgrLiteSettings
                {
                    DatabaseBackupDirectory = @"C:\DatabaseBackups",
                    SalesPadx86Directory = @"C:\Program Files (x86)\SalesPad.Desktop",
                    SalesPadx64Directory = @"C:\Program Files\SalesPad.Desktop"
                };

                string output = JsonConvert.SerializeObject(envMgrLiteSettings, Formatting.Indented);
                File.WriteAllText(@"C:\Users\steve.rodriguez\Downloads\EnvMgrLite\Settings.json", output);
            }

            GenerateEnvMgrSettingsFile();
        }
    }
}
