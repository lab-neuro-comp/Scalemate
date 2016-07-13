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
        public int[] Answers { get; set; } = null;
        public bool Ended { get; private set; } = false;
        public string[] Survey { get; set; }

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

        /******************
        * INVENTORY LOGIC *
        ******************/
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

            Continue();
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

        /****************
        * RESULTS LOGIC *
        ****************/
        public void CalculateScore(int[] answers)
        {
            Answers = answers;
            CalculateScore(Answers.Aggregate(0, (acc, x) => x + acc));
        }

        public void CalculateScore(int score)
        {
            DataParser DP;
            string[] results = DataAccessLayer.Load(DataAccessLayer.GetResultsPath(Test));
            string result = "";

            /* Obtain result */
            foreach (var line in results)
            {
                DP = new DataParser(line);
                int lowerbound = DP.Lowerbound;
                int upperbound = DP.Upperbound;
                string message = DP.Message;

                if (score >= lowerbound && score < upperbound)
                {
                    result = message;
                    break;
                }
            }

            /* Write answers */
            string[] parts = { Test, Patient, string.Format("{0}", score), result };
            DataAccessLayer.Save(DataAccessLayer.GenerateResultsPath(Patient, Test), GenerateCSV(parts));
        }



        private string GenerateTXT(string[] parts)
        {
            int index = 0;
            string[] outlet = new string[parts.Length + 1];

            foreach (var part in parts)
            {
                outlet[index++] = part;
            }
            index = 1;
            outlet[outlet.Length - 1] = Answers.Aggregate("Respostas:\r\n",
                (acc, x) => string.Format("{0}  {1}. {2}\r\n", acc, index++, x));

            return outlet.Aggregate("", (acc, x) => string.Format("{0}{1}\r\n", acc, x));
        }

        private string GenerateCSV(string[] stuff)
        {
            string outlet = "";

            if (Survey == null)
            {
                outlet = stuff.Aggregate("", (box, it) => box + it + "\t") +
                         Answers.Aggregate("\r\n", (box, it) => box + it + "\r\n");
            }
            else
            {
                outlet = stuff.Aggregate("", (box, it) => box + it + "\t") +
                         Survey.Aggregate("\r\n", (box, it) => box + it + "\r\n") +
                         Answers.Aggregate("", (box, it) => box + it + "\r\n");
            }

            return outlet;
        }
    }
}
