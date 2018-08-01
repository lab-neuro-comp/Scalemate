using Newtonsoft.Json;
using ScalemateWPF.Models;
using ScalemateWPF.Views.CreateScale;
using ScalemateWPF.Views.ExecuteScale;
using ScalemateWPF.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace ScalemateWPF.Views.MainWindow
{
    class MainWindowViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        #endregion

        public MainWindowViewModel()
        {
            Queue<Question> _questions = new Queue<Question>();
            List<String> alternatives = new List<String>();
            alternatives.Add("a1");
            alternatives.Add("a2");
            Question q = new Question("asdf", alternatives);
            String json = JsonConvert.SerializeObject(q);
            Console.WriteLine(json);
            Question q2 = Question.createQuestionFromJson(json);

            // Add available pages
            PageViewModels.Add(new CreateScaleViewModel());
            PageViewModels.Add(new ExecuteScaleViewModel());

            // Set starting page
            CurrentPageViewModel = PageViewModels[0];
        }

        #region Properties / Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        #endregion

        #region Methods

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        #endregion
    }
}
