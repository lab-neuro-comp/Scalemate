using ScalemateWPF.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Views.HomePage
{
    class HomePageViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "INICIO";
            }
        }

        public string Row
        {
            get
            {
                return "0";
            }
        }
    }
}
