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
        public string Test { get; private set; } = null;
        public string Patient { get; private set; } = null;
        public string[] RawData { get; private set; } = null;
        public int NoOptions { get; private set; } = 0;
        public Queue<string> Questions { get; private set; } = null;
        public Queue<string> Options { get; private set; } = null;
        public string Question { get; private set; } = null;
        public bool ReverseScore { get; private set; } = false;
        public bool Ended { get; private set; } = false;

        public Tester()
        {
            
        }

        public Tester(string test, string patient) : this()
        {
            SetTest(test);
            SetPatient(patient);
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
            {
                Test = test;
                RawData = DataAccessLayer.Load(DataAccessLayer.GetInventoryPath(Test));
                Setup();
            }
            
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

        /* Inventory logic */
        public void Setup()
        {
            int howMany = 0;
            Questions = new Queue<string>();
            Options = new Queue<string>();
            GetNoOptions();

            foreach (var item in GetQuestions())
            {
                if (howMany % (NoOptions + 1) == 0)
                    Questions.Enqueue(item);
                else
                    Options.Enqueue(item);
                howMany++;
            }
                
        }

        public string NextOption()
        {
            string outlet = Options.Dequeue();
            Ended = (Options.Count == 0) ? true : false;
            return outlet;
        }

        public int GetNoOptions()
        {
            NoOptions = int.Parse(RawData[0]);
            return NoOptions;
        }

        public string[] GetQuestions()
        {
            int limit = RawData.Length - 1;
            string[] outlet = new string[limit];

            for (int i = 1; i < RawData.Length; i++)
                outlet[i - 1] = RawData[i];

            return outlet;
        }

        public int GetNoQuestions()
        {
            return GetQuestions().Length / GetNoOptions();
        }

        public void Continue()
        {
            Question = Questions.Dequeue();

            try
            {
                if (Question[0] == '*')
                {
                    ReverseScore = true;
                    Question = Question.Substring(1);
                }
                else
                {
                    ReverseScore = false;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                ReverseScore = false;
            }
        }

        /* Results logic */
    }
}
