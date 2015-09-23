using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWCFServices;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost svcHost = null;
            try
            {
                svcHost = new ServiceHost(typeof(HelloWorldService));
                svcHost.Open(); Console.WriteLine("\n\nService is Running  at following address");
                Console.WriteLine("\nhttp://localhost:9001/HelloWorldService");
            }
            catch (Exception eX)
            {
                svcHost = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + eX.Message + "]");
            } if (svcHost != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcHost.Close();
                svcHost = null;
            }
        }
    }
}
