﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Data
{
    class DataParser
    {
        private string Inlet { get; set; }
        public int Lowerbound { get; private set; }
        public int Upperbound { get; private set; }
        public string Message { get; private set; }

        public DataParser(string inlet)
        {
            var stuff = inlet.Split('\t');
            Lowerbound = int.Parse(stuff[0]);
            Upperbound = int.Parse(stuff[1]);
            Message = stuff[2];
        }
    }
}
