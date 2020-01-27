using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_To_Metric
{
    class Rounding
    {
        public Rounding() {}

        public double Round(double number)
        {
          return Math.Round(number, 2);   
        }

    }
}
