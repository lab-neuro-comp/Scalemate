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

        private string _scaleName;
        private Scale _scale;
        private ICommand _getScaleCommand;
        private ICommand _saveScaleCommand;
        private ICommand _addQuestionCommand;

        public ObservableCollection<Question> Questions { get; set; }

        public CreateScaleViewModel()
        {
            Questions = new ObservableCollection<Question>();
            AddQuestion();
            AddQuestion();
            AddQuestion();
        }

        #endregion

        #region Properties/Commands

        public string Name
        {
            get { return "Criar teste"; }
        }

        public string Row
        {
            get { return "0"; }
        }

        public string ScaleName
        {
            get { return _scaleName; }
            set
            {
                if (value != _scaleName)
                {
                    _scaleName = value;
                    OnPropertyChanged("TestName");
                }
            }
        }

        public Scale Scale
        {
            get { return _scale; }
            set
            {
                if (value != _scale)
                {
                    _scale = value;
                    OnPropertyChanged("CurrentTest");
                }
            }
        }

        public ICommand GetTestCommand
        {
            get
            {
                if (_getScaleCommand == null)
                {
                    _getScaleCommand = new RelayCommand(
                        param => GetTest(),
                        param => ScaleName != null
                    );
                }
                return _getScaleCommand;
            }
        }

        public ICommand SaveTestCommand
        {
            get
            {
                if (_saveScaleCommand == null)
                {
                    _saveScaleCommand = new RelayCommand(
                        param => SaveTest(),
                        param => (Scale != null)
                    );
                }
                return _saveScaleCommand;
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
                        param => (Scale != null)
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
            Scale p = new Scale();
            Scale = p;
        }

        private void SaveTest()
        {
            // You would implement your Product save here
        }

        private void AddQuestion()
        {
            Questions.Add(new Question());
        }

        #endregion
    }
}
