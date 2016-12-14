using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScalemateForms.Model;

namespace ScalemateForms.Controller
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

        /// <summary>
        /// Create a new test assistant. Will be responsible for controlling the
        /// question flow and for calculating the results after the test completion.
        /// </summary>
        /// <param name="test">The test code</param>
        /// <param name="patient">The patient code</param>
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

        // Finish instructions
        public string GetFinishInstructions()
        {
            string outlet = "";
            string path = DataAccessLayer.GetFinishInstrutionsPath(Test);

            if (DataAccessLayer.FileExists(path))
            {
                outlet = DataAccessLayer.Load(path)
                                        .Aggregate("", (box, it) => $"{box}\n{it}");
            }

            return outlet;
        }

        /******************
        * INVENTORY LOGIC *
        ******************/
        /// <summary>
        /// Creates the queues for the questions and the options.
        /// </summary>
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

        /// <summary>
        /// Sets the state for the next question. That is, sets the new question and 
        /// if this question must reverse the scoring.
        /// </summary>
        public void Continue()
        {
            // TODO There is an inconsistency here. Question and ReverseScore are 
            // part of the tester state, but the current options not. Therefore,
            // make the options part of the state.

            Question = Questions.Dequeue();

            // Checking if it must reverse the score for this question
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
        /// <summary>
        /// Calculates the score for the current test based on the answers given
        /// by the patient; and saves the results on a file as coded by the spec.
        /// </summary>
        /// <param name="answers">The answers given by the patient</param>
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

            // Obtaining result
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

            // Writing answers
            // TODO The results must be part of the tester state too. The form must
            // have it saved, not the tester. Therefore, separate this.
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
                         Answers.Aggregate("\r\n", (box, it) => box + it + "\t");
            }
            else
            {
                outlet = stuff.Aggregate("", (box, it) => box + it + "\t") +
                         Survey.Aggregate("\r\n", (box, it) => box + it + "\t") +
                         Answers.Aggregate("\r\n", (box, it) => box + it + "\t");
            }

            return outlet;
        }
    }
}
