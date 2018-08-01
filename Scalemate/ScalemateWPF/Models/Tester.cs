using ScalemateWPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Models
{
    class Tester
    {
        #region Constructor
        /// <summary>
        /// Constructor taking only the data access layer.
        /// </summary>
        public Tester(DataAccessLayer dal)
        {
            this.DAL = dal;
        }

        /// <summary>
        /// Constructor taking all the information
        /// </summary>
        /// <param name="dal">The data access object</param>
        /// <param name="test">The test identification</param>
        /// <param name="patient">The patient identification</param>
        public Tester(DataAccessLayer dal, string test, string patient) : this(dal)
        {
            Setup(test, patient);
        }

        /// <summary>
        /// Gets the possible tests using the registered DAL.
        /// </summary>
        /// <returns>An array of strings containing each a pair of test ids.</returns>
        public string[] LoadKinds()
        {
            return Tester.LoadKinds(DAL);
        }

        /// <summary>
        /// Gets the possible tests using the given DAL.
        /// </summary>
        /// <param name="dal">The data access layer designed to use.</param>
        /// <returns>An array of strings containing each a pair of test ids.</returns>
        public static string[] LoadKinds(DataAccessLayer dal)
        {
            return dal.Load(dal.GetKindsPath());
        }

        /// <summary>
        /// Prepares the object for the test's execution.
        /// </summary>
        /// <param name="test">The test identification code.</param>
        /// <param name="patient">the patient's identification.</param>
        public void Setup(string test, string patient)
        {
            this.Test = test;
            this.Patient = patient;
            Setup();
        }

        /// <summary>
        /// Prepares the object for the test's execution.
        /// </summary>
        public void Setup()
        {
            // Check for possible files
            var path = DAL.GetInstructionsPath(Test);
            if (DAL.FileExists(path))
            {
                BeginningInstructions = DAL.Load(path);
            }

            path = DAL.GetFinishInstrutionsPath(Test);
            if (DAL.FileExists(path))
            {
                EndingInstructions = DAL.Load(path);
            }

            path = DAL.GetInformationPath(Test);
            if (DAL.FileExists(path))
            {
                SurveyQuestions = DAL.Load(path);
                SurveyAnswers = new string[SurveyQuestions.Length];
            }

            // Loading data
            // IDEA Leave this CSV conversion to the data access class or to the Model layer
            RawData = DAL.Load(DAL.GetInventoryPath(Test));
            questions = new Queue<Question>();

            foreach (var line in RawData)
            {
                Question question = new Question();
                var itens = line.Split('\t');
                question.question = itens[0];
                foreach (var item in itens.Skip(1).Where(it => it.Length > 0))
                    question.addOneAlternative(item);
                questions.Enqueue(question);
            }
            test = new Test(questions);

            // Building reverse scores
            //var normalized = Questions.Select(it => (it.Length == 0) ? " " : it);
            //ReverseScores = new Queue<bool>(normalized.Select(it => (it[0] == '*') ? true : false));
            //Questions = new Queue<string>(normalized.Select(it => ((it[0] == '*')) ? it.Substring(1) : it));


            Answers = new Queue<int>();
            Continue();
        }
        #endregion

        #region Methods

        /* ##############
           # TEST LOGIC #
           ############## */

        /// <summary>
        /// Sets the state for the next question. That is, sets the new question and
        /// if this question must reverse the scoring.
        /// </summary>
        public void Continue()
        {
            // Setting current question
            question = test.getNextQuestion();

            Ended = (question.alternatives.Count == 0) ? true : false;
        }

        /// <summary>
        /// Gets the answer to the current question.
        /// This class will handle the reverse scoring logic, so no need to try to reverse it.
        /// Remember that the first option is worth 0 points, the second option is worth 1 points,
        /// so on so forth.
        /// </summary>
        /// <param name="answer">The given answer.</param>
        public void Listen(int answer)
        {
            ReverseScore = ReverseScores.Dequeue();
            if (ReverseScore)
            {
                //answer = NoOptions - answer - 1;
            }
            Answers.Enqueue(answer);
        }

        /* #################
           # SCORING LOGIC #
           ################# */

        /// <summary>
        /// Generates the output TSV table as described on specs based on the test's result;
        /// and saves this table into memory.
        /// </summary>
        /// <returns>A string containing the raw TSV table.</returns>
        public string CalculateResults()
        {
            return CalculateResults(true);
        }

        /// <summary>
        /// Generates the output TSV table as described on specs based on the test's result.
        /// </summary>
        /// <param name="mustSave">If set to true, will save this TSV table on the standard
        /// name for that test's execution.</param>
        /// <returns>A string containing the raw CSV table.</returns>
        public string CalculateResults(bool mustSave)
        {
            DataParser DP;
            string[] results = DAL.Load(DAL.GetResultsPath(Test));
            string result = "";

            // Obtaining result
            Score = Answers.Sum();

            foreach (var line in results)
            {
                DP = new DataParser(line);
                int lowerbound = DP.Lowerbound;
                int upperbound = DP.Upperbound;
                string message = DP.Message;

                if (Score >= lowerbound && Score < upperbound)
                {
                    result = message;
                    break;
                }
            }

            // Generating TSV table output
            string[] parts = { Test, Patient, Score.ToString(), result };
            var outlet = GenerateTSV(parts);

            if (mustSave)
            {
                DAL.Save(DAL.GenerateResultsPath(Patient, Test), outlet);
            }

            return outlet;
        }

        /// <summary>
        /// Generates a TSV table based on the results of the test.
        /// </summary>
        /// <param name="stuff">An array containing information to identify that
        /// patient. Will contain the test's id, the patient's id, the score and the
        /// results as calculated by Scalemate based on the test design.</param>
        /// <returns>The raw TSV table.</returns>
        private string GenerateTSV(string[] stuff)
        {
            string outlet = "";

            if (SurveyAnswers == null)
            {
                outlet = stuff.Aggregate("", (box, it) => box + it + "\t")
                       + Answers.Aggregate("\r\n", (box, it) => box + it + "\t");
            }
            else
            {
                outlet = stuff.Aggregate("", (box, it) => box + it + "\t")
                       + SurveyAnswers.Aggregate("\r\n", (box, it) => box + it + "\t")
                       + Answers.Aggregate("\r\n", (box, it) => box + it + "\t");
            }

            return outlet;
        }
        #endregion
            

        #region Properties
        private DataAccessLayer _DAL_ { get; set; } = null;
        public DataAccessLayer DAL
        {
            get { return _DAL_; }
            set { _DAL_ = (_DAL_ == null) ? value : _DAL_; }
        }
        public string Test { get; private set; } = null;
        public string Patient { get; private set; } = null;
        public string[] RawData { get; private set; } = null;
        public Queue<Question> questions { get; private set; } = null;
        public Question question { get; private set; } = null;
        public Test test { get; private set; } = null;
        public bool ReverseScore { get; private set; } = false;
        public Queue<bool> ReverseScores { get; private set; } = null;
        public Queue<int> Answers { get; set; } = null;
        public bool Ended { get; private set; } = false;
        public int Score { get; private set; } = 0;
        public string[] SurveyQuestions { get; private set; } = null;
        public string[] SurveyAnswers { get; set; } = null;
        public string[] BeginningInstructions { get; private set; } = null;
        public string[] EndingInstructions { get; private set; } = null;
        #endregion
    }
}
