﻿using ScalemateWPF.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Views.ResultsScale
{
    class ResultsScaleViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "RESULTADOS";
            }
        }

        public string Row
        {
            get
            {
                return "3";
            }
        }
    }
}
