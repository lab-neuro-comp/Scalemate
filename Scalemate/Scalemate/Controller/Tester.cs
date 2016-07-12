using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scalemate.Model;

namespace Scalemate.Controller
{
    public class Tester
    {
        public string Test { get; private set; }
        public string Patient { get; private set; }

        public Tester()
        {
            Test = null;
            Patient = null;
        }

        /* To Model */
        public static string[] LoadKinds()
        {
            return DataAccessLayer.Load(@"assets\kinds.txt");
        }

        /* To View */
        public string SetTest(string test)
        {
            if (Test == null)
                Test = test;
            return Test;
        }

        public string SetPatient(string it)
        {
            if (Patient == null)
                Patient = it;
            return Patient;
        }

        // Instructions
        public bool AreThereInstructions()
        {
            return DataAccessLayer.FileExists(DataAccessLayer.GetInstructionsPath(Test));
        }

        public string LoadInstructions()
        {
            return DataAccessLayer.Load(DataAccessLayer.GetInstructionsPath(Test))
                                  .Aggregate((box, it) => box + "\n" + it);
        }

        // Information survey
        public bool IsThereSurvey()
        {
            return DataAccessLayer.FileExists(DataAccessLayer.GetInformationPath(Test));
        }

        public string[] LoadSurvey()
        {
            return DataAccessLayer.Load(DataAccessLayer.GetInformationPath(Test));
        }
    }
}
