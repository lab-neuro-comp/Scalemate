using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scalemate;

namespace ScalemateForms.Model
{
    class DataAccessLayer
    {
        static public string[] Load(string path)
        {
            List<string> data = new List<string>();

            using (var serial = new StreamReader(path))
            {
                for (var line = serial.ReadLine(); line != null; line = serial.ReadLine())
                {
                    data.Add(line);
                }
            }

            return data.ToArray<string>();
        }

        static public void Save(string where, string what)
        {
            File.WriteAllText(where, what);
        }

        static public string GetInventoryPath(string test)
        {
            return string.Format("assets\\{0}\\inventory.txt", test);
        }

        static public string GetResultsPath(string test)
        {
            return string.Format("assets\\{0}\\results.txt", test);
        }

        static public string GetInstructionsPath(string test)
        {
            return string.Format("assets\\{0}\\instructions.txt", test);
        }

        static public string GetInformationPath(string test)
        {
            return string.Format("assets\\{0}\\information.txt", test);
        }

        static public string GetFinishInstrutionsPath(string test)
        {
            return string.Format(@"assets\{0}\finish.txt", test);
        }


        static public string GenerateResultsPath(string patient, string test)
        {
            return string.Format("results\\{0}_{1}.csv", patient.Split(' ')
                                                                .Aggregate((acc, x) => acc + x),
                                                         test);
        }

        static public bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
