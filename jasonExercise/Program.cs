using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jasonExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please type a number");
            int result = int.Parse(Console.ReadLine());

            for (int number = 1; number <= result; number++)
            {
                bool fizz = number % 3 == 0;
                bool buzz = number % 5 == 0;

                if (fizz)
                {
                    Console.WriteLine("{0}. fizz", number);
                }
                else if (buzz)
                {
                    Console.WriteLine("{0}. buzz", number);
                }
                else
                {
                    Console.WriteLine("{0}.", number);
                }
            }
            Console.ReadLine();
        }
    }
}
