using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateProject.Model
{
    public class Alternative
    {
        private String _name;
        private int _value;

        public Alternative(string name, int value)
        {
            _name = name;
            _value = value;
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}
