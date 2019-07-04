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
            return (double)centimeters / 2.54;
        }

        public string getInches()
        {
            return Convert.ToString(_inches);
        }
    }
}
