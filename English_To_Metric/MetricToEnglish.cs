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

        private int kilometersToMeters(int kilometers)
        {
            return kilometers * 100;
        }

        private int metersToCentimeters(int meters)
        {
            return meters * 100;
        }

        private double centimetersToInches(int centimeters)
        {
            double totalCentimeter = centimeters / 2.54;

            return double.Parse(totalCentimeter.ToString("#.##"));
        }

        private int inchesToFeet(double inches)
        {
            return (int)inches / 12;
        }

        private int feetToYards(int feet)
        {
            return feet / 3;
        }

        private int yardsToFeet(int yards)
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
