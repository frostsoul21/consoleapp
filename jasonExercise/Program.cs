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
            int resultPlus1 = result + 1;
            Console.WriteLine("Your new number is:");
            Console.WriteLine(resultPlus1);
                if (resultPlus1 % 3 == 0)
                {
                Console.WriteLine("fizz");
                }
                else if (resultPlus1 % 5 == 0)
                {
                Console.WriteLine("buzz");
                }
                else
                {
                Console.WriteLine("The new number is not evenly devisible by 3 or 5. ");
                }
            Console.ReadLine();
        }
    }
}
