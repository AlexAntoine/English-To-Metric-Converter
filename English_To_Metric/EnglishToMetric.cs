using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_To_Metric
{
    class EnglishToMetric
    {
        private double centimeters;
        private int meters;
        private int kilometer;

        public EnglishToMetric(string userMiles, string userYards, string userFeet, string userInches)
        {

            centimeters = milesToYards(int.Parse(userMiles)) + Convert.ToInt16(userFeet);
        }

        public int milesToYards(int miles)
        {
            return miles * 1760;
        }

        public int yardsToFeet(int yards)
        {
            return yards * 3;
        }

        public double feetToInches(int feet)
        {
            return feet * 2.54;
        }


    }
}
