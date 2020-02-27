using System.ServiceModel;
using static System.Console;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(Service));
            serviceHost.Open();

            WriteLine("Service is running.");
            ReadLine();

            serviceHost.Close();

            WriteLine("Service is stopped.");
        }
    }
}