using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_To_Metric
{
    class Rounding
    {
        public Rounding()
        {

        }

        public double round(double numerToRound, int numberPlace)
        {
            double tempDouble = (numerToRound * Math.Pow(10, numberPlace));

            tempDouble += .5;

            int tempInt = (int)tempDouble;

            tempDouble = tempInt / Math.Pow(10, numberPlace);

            return tempDouble;
        }
    }
}
