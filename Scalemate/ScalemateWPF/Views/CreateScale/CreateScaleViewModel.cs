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
        
        private Scale _scale;
        private ICommand _getScaleCommand;
        private ICommand _saveScaleCommand;
        private ICommand _addQuestionCommand;

        public ObservableCollection<Question> Questions { get; set; }

        public CreateScaleViewModel()
        {
            Questions = new ObservableCollection<Question>();
            Scale = new Scale();
            Scale.Name = "af";
            AddQuestion();
            AddQuestion();
            AddQuestion();
        }

        #endregion

        #region Properties/Commands

        public string Name
        {
            get { return "CRIAR TESTE"; }
        }

        public string Row
        {
            get { return "1"; }
        }

        public Scale Scale
        {
            get { return _scale; }
            set
            {
                if (value != _scale)
                {
                    _scale = value;
                    //OnPropertyChanged("CurrentTest");
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
                        param => Scale.Name != null
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
            List<String> alternatives = new List<String>
            {
                "a",
                "b"
            };
            Questions.Add(new Question("teste", alternatives));
        }

        #endregion
    }
}
