using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateForms.View
{
    public interface IParent
    {
        void Show();
        void Hide();
        string Get(string tag);
    }
}
