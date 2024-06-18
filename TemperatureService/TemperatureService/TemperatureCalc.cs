using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TemperatureService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TemperatureCalc" in both code and config file together.
    public class TemperatureCalc : ITemperatureCalc
    {
        public double GetCelsius(Temperature temp)
        {
            return (temp.Fahrenheit - 32) * 5 / 9;
        }
        public double GetFahrenheit(Temperature temp)
        {
            return (temp.Celsius * 9) / 5 + 32;
        }
    }
}
