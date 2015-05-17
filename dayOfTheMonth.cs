using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayOfTheMonth
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to day of the month program");
            Console.WriteLine("\n");
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Thank you" + name);

            bool cont = true;

            while(cont)
            {
                Console.WriteLine(name + "Please enter a day of the Month");
                int day = Convert.ToInt32(Console.ReadLine());
                if (day >= 1 & day <=31)
                {
                    Console.WriteLine(name + "you have entered a valid day in a month");
                    cont = false;
                }
                else
                {
                    Console.WriteLine(name + "you have entered a wrong day in the month");
                    Console.ReadLine();
                }

            }
            Console.WriteLine("Thank you " + name + "for participating today");
            Console.ReadLine();

        
        
        }
    }
}
