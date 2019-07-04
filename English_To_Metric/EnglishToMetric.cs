using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_To_Metric
{
    class EnglishToMetric
    {
        private double _centimeters;
        private int _meters;
        private int _kilometer;

        public EnglishToMetric(string userMiles, string userYards, string userFeet, string userInches)
        {
            int totalYards = milesToYards(int.Parse(userMiles)) + Convert.ToInt16(userYards);

            int totalFeet = yardsToFeet(totalYards) + int.Parse(userFeet);

            double totalInches = feetToInches(totalFeet) + int.Parse(userInches);

            _centimeters = inchesToCentimeters(totalInches);

            _meters = centimetersToMeters(_centimeters);

            _kilometer = metersToKilometers(_meters);
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
            return feet * 12;
        }

        public double inchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }

        public int centimetersToMeters(double centimeters)
        {
            return (int)centimeters / 100;
        }

        public int metersToKilometers(int meters)
        {
            return meters / 1000;
        }

        public string getCentimeters()
        {
            return Convert.ToString(_centimeters);
        }

        public string getMeters()
        {
            return Convert.ToString(_meters);
        }

        public string getKilometers()
        {
            return Convert.ToString(_kilometer);
        }


    }
}
