using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scalemate;

namespace ScalemateForms.Model
{
    public class DataAccessLayer : IDataAccessLayer
    {
        public string[] Load(string path)
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

        public void Save(string where, string what)
        {
            File.WriteAllText(where, what);
        }

        public string GetInventoryPath(string test)
        {
            return string.Format("assets\\{0}\\inventory.csv", test);
        }

        public string GetResultsPath(string test)
        {
            return string.Format("assets\\{0}\\results.csv", test);
        }

        public string GetInstructionsPath(string test)
        {
            return string.Format("assets\\{0}\\instructions.txt", test);
        }

        public string GetInformationPath(string test)
        {
            return string.Format("assets\\{0}\\information.txt", test);
        }

        public string GetFinishInstrutionsPath(string test)
        {
            return string.Format(@"assets\{0}\finish.txt", test);
        }


        public string GenerateResultsPath(string patient, string test)
        {
            return string.Format("results\\{0}_{1}.csv", patient.Split(' ')
                                                                .Aggregate((acc, x) => acc + x),
                                                         test);
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public string GetKindsPath()
        {
            return "assets\\kinds.csv";
        }

        public string GetDocsPath()
        {
            return @"assets\README.html";
        }
    }
}
