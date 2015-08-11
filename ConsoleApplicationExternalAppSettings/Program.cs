using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationExternalAppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foo = {0}", ConfigurationManager.AppSettings["foo"]);
            Console.WriteLine("Bar = {0}", ConfigurationManager.AppSettings["bar"]);
        }
    }
}
