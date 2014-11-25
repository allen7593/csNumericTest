using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please input a string to check: ");
            input=Console.ReadLine();
            if (isNum(input))
            {
                Console.WriteLine("Is number");
            }
            else
                Console.WriteLine("Is not number");

            Console.ReadLine();
        }


        private static bool isNum(string input)
        {
            try
            {
                double a = Convert.ToDouble(input);
                Console.WriteLine(a.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }
    }
}
