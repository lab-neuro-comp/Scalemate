using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scalemate
{
    public class Tester
    {
        #region Constructor
        /// <summary>
        /// Constructor taking only the data access layer.
        /// </summary>
        public Tester(IDataAccessLayer dal)
        {
            this.DAL = dal;
        }

        /// <summary>
        /// Constructor taking all the information
        /// </summary>
        /// <param name="dal">The data access object</param>
        /// <param name="test">The test identification</param>
        /// <param name="patient">The patient identification</param>
        public Tester(IDataAccessLayer dal, string test, string patient) : this(dal)
        {
            Setup(test, patient);
        }

        /// <summary>
        /// Gets the possible tests using the registered DAL.
        /// </summary>
        /// <returns>An array of strings containing each a pair of test ids </returns>
        public string[] LoadKinds()
        {
            return Tester.LoadKinds(DAL);
        }

        /// <summary>
        /// Gets the possible tests using the given DAL.
        /// </summary>
        /// <param name="dal">The data access layer designed to use.</param>
        /// <returns>An array of strings containing each a pair of test ids.</returns>
        public static string[] LoadKinds(IDataAccessLayer dal)
        {
            return dal.Load(dal.GetKindsPath());
        }

        public void Setup(string test, string patient)
        {
            this.Test = test;
            this.Patient = patient;
            Setup();
        }

        public void Setup()
        {
            // Check for possible files
            // TODO Check for instructions, ending instructions and survey files

            // Loads data
            // TODO Load data

        }
        #endregion

        #region Methods

        #endregion


        #region Properties
        private IDataAccessLayer _DAL_ { get; set; }
        public IDataAccessLayer DAL
        {
            get { return _DAL_; }
            set { _DAL_ = (_DAL_ == null) ? value : _DAL_; }
        }
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
        public string[] Survey { get; private set; }
        #endregion
    }
}
