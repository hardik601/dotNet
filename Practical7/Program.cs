using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rupee, dollar, frank, euro;
            Console.Write("Enter amount in rupees: ");
            rupee = decimal.Parse(Console.ReadLine());

            dollar = 0.01357M * rupee;

            frank = 0.01267M * rupee;

            euro = 0.01199M * rupee;

            Console.WriteLine($"INR {rupee} = {dollar.ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine($"INR {rupee} = {frank.ToString("C", new CultureInfo("de-CH"))}");
            Console.WriteLine($"INR {rupee} = {euro.ToString("C", new CultureInfo("en-GB"))}");
            Console.ReadKey();
        }
    }
}
