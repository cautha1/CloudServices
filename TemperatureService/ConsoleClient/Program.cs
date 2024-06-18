using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ServiceReference1;
namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 0;
            //step 1 - create an instance of wcf proxy
            TemperatureCalcClient client = new TemperatureCalcClient();
            Temperature temp = new Temperature();
            temp.Fahrenheit = 212;
            temp.Celsius = 0;
            c = client.GetCelsius(temp);
            Console.WriteLine("Celsuis value is {0:F2}",c);

        }
    }
}
