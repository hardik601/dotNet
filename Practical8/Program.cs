using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Celsius to Farenheit");
            Console.WriteLine("2) Farenheit to Celsius");
            Console.Write("Please enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            float celsius;
            float farenheit;
            switch(choice)
            {
                case 1:
                    Console.Write("Enter temperature in celsius: ");
                    celsius = float.Parse(Console.ReadLine());
                    farenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"{celsius} celsius = {farenheit} farehheit");
                    break;
                case 2:
                    Console.Write("Enter temperature in farenheit: ");
                    farenheit = float.Parse(Console.ReadLine());
                    celsius = (farenheit - 32) * 5 / 9;
                    Console.WriteLine($"{farenheit} farehheit = {celsius} celsius");
                    break;
                default:
                    Console.WriteLine("Please select valid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
