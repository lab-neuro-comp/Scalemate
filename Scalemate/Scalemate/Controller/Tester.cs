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
        public string[] LoadKinds()
        {
            return DataAccessLayer.Load(@"assets\kinds.txt");
        }

        public string GetInstructionsPath(string test)
        {
            return DataAccessLayer.GetInstructionsPath(test);
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
    }
}
