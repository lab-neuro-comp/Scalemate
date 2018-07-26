using ScalemateWPF.Models;
using ScalemateWPF.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ScalemateWPF.Views.CreateScale
{
    class CreateScaleViewModel : ObservableObject, IPageViewModel
    {
        #region Fields

        private string _testName;
        private Tester _currentTest;
        private ICommand _getTestCommand;
        private ICommand _saveTestCommand;
        private ICommand _addQuestionCommand;
        private ObservableCollection<TextBoxVm> _items = new ObservableCollection<TextBoxVm>();
        internal ObservableCollection<TextBoxVm> Items { get => _items; }
        #endregion

        #region Properties/Commands

        public string Name
        {
            get { return "Criar nova escala comportamental"; }
        }

        public int Column
        {
            get { return 0; }
        }

        public string TestName
        {
            get { return _testName; }
            set
            {
                if (value != _testName)
                {
                    _testName = value;
                    OnPropertyChanged("TestName");
                }
            }
        }

        public Tester CurrentTest
        {
            get { return _currentTest; }
            set
            {
                if (value != _currentTest)
                {
                    _currentTest = value;
                    OnPropertyChanged("CurrentTest");
                }
            }
        }

        public ICommand GetTestCommand
        {
            get
            {
                if (_getTestCommand == null)
                {
                    _getTestCommand = new RelayCommand(
                        param => GetTest(),
                        param => TestName != null
                    );
                }
                return _getTestCommand;
            }
        }

        public ICommand SaveTestCommand
        {
            get
            {
                if (_saveTestCommand == null)
                {
                    _saveTestCommand = new RelayCommand(
                        param => SaveTest(),
                        param => (CurrentTest != null)
                    );
                }
                return _saveTestCommand;
            }
        }

        public ICommand AddQuestionCommand
        {
            get
            {
                if (_addQuestionCommand == null)
                {
                    _addQuestionCommand = new RelayCommand(
                        param => AddQuestion(),
                        param => (CurrentTest != null)
                        );
                }
                return _addQuestionCommand;
            }

        }

        #endregion

        #region Methods

        private void GetTest()
        {
            // Usually you'd get your Product from your datastore,
            // but for now we'll just return a new object
            Tester p = new Tester(null);
            CurrentTest = p;
        }

        private void SaveTest()
        {
            // You would implement your Product save here
        }

        private void AddQuestion()
        {
            Items.Add(new TextBoxVm
            {
                TitleText = string.Format("Pergunta Número {0}:", Items.Count + 1)
            });
        }

        #endregion
    }
}
