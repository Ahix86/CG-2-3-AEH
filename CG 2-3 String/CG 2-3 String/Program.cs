using System;

namespace CG_2_3_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What month were you born:  ");
            string month = Console.ReadLine();

            Console.Write("What day were you born:  ");
            string day = Console.ReadLine();

            Console.Write("What year were you born:  ");
            string year = Console.ReadLine();

            string birthday = month + " " + day + ", " + year;

            Console.WriteLine("Your birthday is " + birthday + ".");
            Console.ReadLine();

        }
    }
}
