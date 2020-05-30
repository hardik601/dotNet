using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter infix string: ");
            string infix = Console.ReadLine();
            string postfix;
            InfixToPostfix converter = new InfixToPostfix();
            converter.infixtopostfix(infix,out postfix); //out keyword is used to pass values by references.
            Console.WriteLine("\nInfix Expression is: " + infix);
            Console.WriteLine("Postfix Expression is: " + postfix);
            Console.ReadKey();
        }
    }
}
