using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _18Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string country;
            do
            {
            Console.WriteLine("What's your name::");
            name = Console.ReadLine();
            }while(!Regex.IsMatch(name,@"^[a-zA-z]+$"));

            do
            {
            Console.WriteLine("where are you from::");
            country = Console.ReadLine();
            }while (!Regex.IsMatch(country, @"^[a-zA-z]+$"));

            Console.WriteLine(" HELLO, I am " + name + " From country " + country);
            Console.ReadLine();
        }
    }
}
