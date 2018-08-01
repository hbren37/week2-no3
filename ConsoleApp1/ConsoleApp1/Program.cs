using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.Write("Please enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("what is your address");
            string addy = Console.ReadLine();
            Console.WriteLine(" Your address is {0}", addy);
            Console.WriteLine("Are you female or Male");
            string gender = Console.ReadLine();
            Console.WriteLine("Great! please enter your two favourite numbers");
            Console.WriteLine("First number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            int num2 = int.Parse(Console.ReadLine());
            int answer = num1 + num2;
            Console.WriteLine("Thses two numbers added together equals {0}", answer);


            Console.ReadLine();

  








        }
    }
}
