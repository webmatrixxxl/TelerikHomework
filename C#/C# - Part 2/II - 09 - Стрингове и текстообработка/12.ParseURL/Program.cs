using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL address given in the format:  [protocol]://[server]/[resource]


//        and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"


namespace _12.ParseURL
{
    class Program
    {
        static void Main()
        {
            Uri uri = new Uri("http://www.devbg.org/forum/index.php");
            Console.WriteLine("  [protocol] = \"{0}\"", uri.Scheme);
            Console.WriteLine("  [server] = \"{0}\"", uri.Host);
            Console.WriteLine("  [resource]= \"{0}\"", uri.AbsolutePath);
        }
    }
}
