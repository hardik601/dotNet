using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    class Program
    {
        static string unique(string input)
        {
            if(input.Length==1)
            {
                switch(input[0])
                {
                    case '0':return "zero";
                    case '1': return "one";
                    case '2': return "two";
                    case '3': return "three";
                    case '4': return "four";
                    case '5': return "five";
                    case '6': return "six";
                    case '7': return "seven";
                    case '8': return "eight";
                    case '9': return "nine";
                    default: return "invalid";
                }
            }
            else
            {
                switch (input[1])
                {
                    case '0': return "ten";
                    case '1': return "elven";
                    case '2': return "tweleve";
                    case '3': return "thirteen";
                    case '4': return "fourteen";
                    case '5': return "fifteen";
                    case '6': return "sixteen";
                    case '7': return "seventeen";
                    case '8': return "eighteen";
                    case '9': return "nineteen";
                    default: return "invalid";
                }
            }
        }
        static string ty(string input)
        {
                switch(input[0])
                {
                    case '0': return unique(input[1].ToString());
                    case '2': return "twenty" + ((input[1]!='0')?" " + unique(input[1].ToString()):"");
                    case '3': return "thirty" + ((input[1] != '0') ? " " + unique(input[1].ToString()) : "");
                    case '4': return "fourty" + ((input[1] != '0') ? " " + unique(input[1].ToString()) : "");
                    case '5': return "fifty" + ((input[1] != '0') ? " " + unique(input[1].ToString()) : "");
                    case '6': return "sixty" + ((input[1] != '0') ? " " + unique(input[1].ToString()) : "");
                    case '7': return "seventy" + ((input[1] != '0') ? " " + unique(input[1].ToString()) : "");
                    case '8': return "eighty" + ((input[1] != '0') ? " " + unique(input[1].ToString()) : "");
                    case '9': return "ninety" + ((input[1] != '0') ? " " + unique(input[1].ToString()) : "");
                    default: return "invalid";
                }
        }
        static void Main(string[] args)
        {
            string number;
            Console.Write("Please input number: ");
            number = Console.ReadLine();
            int length = number.Length;
            if (number.Length == 1 || (number.Length == 2 && number[0] == '1'))
            {
                string result = unique(number);
                string output = result[0].ToString().ToUpper() + result.Substring(1);
                Console.WriteLine(output);
            }
            else if(number.Length == 2)
            {
                string result = ty(number);
                string output = result[0].ToString().ToUpper() + result.Substring(1);
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    }
}
