using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch 
//all exceptions and to free any used resources in the finally block.


namespace _04.DownloadFileFormInternetException
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
                    Console.WriteLine("Download succesful");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The address can not be null");
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("The address is invalid or no internet connectivity.");
                }

                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
                }
                finally
                {
                    webClient.Dispose();
                }
            }
        }
    }
}
