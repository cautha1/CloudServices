using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using TemperatureService;
namespace ConsoleHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/TemperatureService");

            //step 2 create a service host instance
            ServiceHost selfHost = new ServiceHost(typeof(TemperatureCalc), baseAddress);

            try
            {
                //step 3 addd service to endpoint
                selfHost.AddServiceEndpoint(typeof(TemperatureCalc), new WSHttpBinding(), "TemperatureService.ITemperatureCalc");

                //step 4 enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                //step 5 start the service
                selfHost.Open();
                Console.WriteLine("The service is ready");

                //close the service host to stop the service
                Console.WriteLine("Press <Enter> to termiante the serivce ");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();

            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occured: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    
    }
}
