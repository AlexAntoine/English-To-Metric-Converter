using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_To_Metric
{
    class MetricToEnglish
    {
        private double _inches;
        private int _yards;
        private int _feet;
        private int _miles;

        public MetricToEnglish(string userMeters, string userKilometers, string userCentimeters)
        {
            int totalMeters = kilometersToMeters(int.Parse(userKilometers)) + int.Parse(userMeters);

            int centimeters = metersToCentimeters(totalMeters) + int.Parse(userCentimeters);

            _inches = centimetersToInches(centimeters);

            _feet = inchesToFeet(_inches);

            _yards = feetToYards(_feet);

            _miles = yardsToFeet(_yards);
        }

        public int kilometersToMeters(int kilometers)
        {
            return kilometers * 100;
        }

        public int metersToCentimeters(int meters)
        {
            return meters * 100;
        }
        public double centimetersToInches(int centimeters)
        {
            return centimeters / .254;
        }

        public int inchesToFeet(double inches)
        {
            return (int)inches / 12 ;
        }

        public int feetToYards(int feet)
        {
            return feet / 3;
        }

        public int yardsToFeet(int yards)
        {
            return yards / 5280;
        }

        public string getInches()
        {
            return Convert.ToString(_inches);
        }

        public string getFeet()
        {
            return Convert.ToString(_feet);
        }

        public string getYards()
        {
            return Convert.ToString(_yards);
        }

        public string getMiles()
        {
            return Convert.ToString(_miles);
        }
    }
}
