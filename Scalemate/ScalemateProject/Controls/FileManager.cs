using Newtonsoft.Json;
using ScalemateProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalemateProject.Controls
{
    class FileManager
    {
        private static string scaleFolder = "/scale/";
        private static string resultFolder = "/results/";
        private static string path = Path.GetDirectoryName(Application.ExecutablePath);
        public static void prepareDirectories()
        {
            if (!Directory.Exists(path + scaleFolder))
            {
                Directory.CreateDirectory(path + scaleFolder);
            }
            if(!Directory.Exists(path + resultFolder))
            {
                Directory.CreateDirectory(path + resultFolder);
            }
        }
        public static void SaveScale(Scale scale)
        {
            String scaleToString = JsonConvert.SerializeObject(scale);
            File.WriteAllText(path + scaleFolder + scale.Name + ".json", scaleToString);
        }
    }
}
