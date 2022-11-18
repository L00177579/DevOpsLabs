using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();
            if (args[0] == "mutliply")
            {
                Console.WriteLine(businessLogic.Addition(double.Parse(args[1]), double.Parse(args[2])));
            }
            else if (args[0] == "addition")
            {
                Console.WriteLine(businessLogic.Multiplication(double.Parse(args[1]), double.Parse(args[2])));
            }
            else
            {
                Console.WriteLine("Invalid arguments");
            }
        }
    }
}
