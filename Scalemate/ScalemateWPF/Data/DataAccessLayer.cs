using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Data
{
    public class DataAccessLayer
    {
        /// <summary>
        /// Loads a file into its lines.
        /// </summary>
        public string[] Load(string path)
        {
            List<string> data = new List<string>();

            if (FileExists(path))
            {
                using (var serial = new StreamReader(path))
                {
                    for (var line = serial.ReadLine(); line != null; line = serial.ReadLine())
                    {
                        data.Add(line);
                    }
                }
            }

            return data.ToArray<string>();
        }

        /// <summary>
        /// Save a string into a file.
        /// </summary>
        /// <param name="where">The path to save the file</param>
        /// <param name="what">The content to be saved</param>
        public void Save(string where, string what)
        {
            File.WriteAllText(where, what);
        }

        /// <summary>
        /// Gets the path to the inventory file based on the test name.
        /// </summary>
        public string GetInventoryPath(string test)
        {
            return string.Format("assets\\{0}\\inventory.csv", test);
        }

        /// <summary>
        /// Gets the path to the file describing how to score a given test.
        /// </summary>
        public string GetResultsPath(string test)
        {
            return string.Format("assets\\{0}\\results.csv", test);
        }

        /// <summary>
        /// Gets the path to the file containing the instructions to be given based on the test id.
        /// </summary>
        public string GetInstructionsPath(string test)
        {
            return string.Format("assets\\{0}\\instructions.txt", test);
        }

        /// <summary>
        /// Gets the path to the file indicating which questions to survey to the user before
        /// the test's beginning.
        /// </summary>
        public string GetInformationPath(string test)
        {
            return string.Format("assets\\{0}\\information.txt", test);
        }

        /// <summary>
        /// Gets the file where the finish instructions are written.
        /// </summary>
        public string GetFinishInstrutionsPath(string test)
        {
            return string.Format(@"assets\{0}\finish.txt", test);
        }

        public string GetPreferencesPath()
        {
            return ".\\assets\\preferences.csv";
        }

        /// <summary>
        /// Creates a path to the file containing the results of the test based on the
        /// test code and on the patient name.
        /// </summary>
        public string GenerateResultsPath(string patient, string test)
        {
            return string.Format("results\\{0}_{1}.csv", patient.Split(' ')
                                                                .Aggregate((acc, x) => acc + x),
                                                         test);
        }

        /// <summary>
        /// Checks if the given file exist
        /// </summary>
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        /// Gets the path to the file containing the available tests and their codes.
        /// </summary>
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
