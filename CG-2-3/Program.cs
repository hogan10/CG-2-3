using System;

namespace CG_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name");
            string myFirstName = Console.ReadLine();

            Console.Write("Enter your birth month");
            string myBirthMonth = Console.ReadLine();

            Console.Write("Enter your birth day");
            string myBirthDay = Console.ReadLine();

            Console.WriteLine("Here is your name and birthday:" + " " + myFirstName + myBirthMonth + myBirthDay);
            Console.ReadLine();
        }
    }
}
