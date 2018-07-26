using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Views.Helpers
{
    public interface IPageViewModel
    {
        string Name { get; }
        int Column { get; }
    }
}
