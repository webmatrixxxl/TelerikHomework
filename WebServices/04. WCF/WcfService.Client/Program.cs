using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Client.ServiceReference1;

namespace WcfService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            
            Console.WriteLine(client.GetData(DateTime.Now));
        }
    }
}
