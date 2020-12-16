using System;
using static Calc.Add;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            while (true) {
                Console.WriteLine("Enter First Number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Operation");
                string strop = Console.ReadLine();
                char op = char.Parse(strop); 
                Console.WriteLine("Enter Second Number");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine($"{x}{op}{y}");

                if (op == '+')
                {
                    Add.Main(x,y);
                }
                else if (op == '-')
                {
                    Sub.Main(x,y);
                }
                else if (op == '*')
                {
                    Mult.Main(x,y);
                }
                else if (op == '/')
                {
                    Div.Main(x,y);
                }
                else {
                    Console.WriteLine("Command Not Yet Supported");
                }
            }
        }
    }
}
