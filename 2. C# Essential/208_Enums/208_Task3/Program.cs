using System;

namespace _208_Task3
{
    enum Post
    {
        JuniorStructuralEngineer = 15,
        StructuralEngineer = 40,
        TeamLeader = 40,
        Receptionist = 20,
        Driver = 20,
        CofeeLady = 30
    }

    static class Accountant
    {
        static public bool AskForBonus(Post worker, int hours)
        {
            bool IsWorthBonus = hours - (int)worker > 0;
            return IsWorthBonus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a capacity");
            string capacity = Console.ReadLine();

            bool flag = Enum.IsDefined(typeof(Post), capacity);

            Post capacityName = Post.Driver;

            if (flag == true)
            {
                Type @enum = capacityName.GetType();
                object o = Enum.Parse(@enum, capacity);
                capacityName = (Post)o;

                Console.WriteLine("How many hours did the worker worked in this month?");

                int hours = Convert.ToInt32(Console.ReadLine());

                bool bonus = Accountant.AskForBonus(capacityName, hours);

                if (bonus)
                {
                    Console.WriteLine("Bonus should be allocated");
                }
                else
                {
                    Console.WriteLine("Bonus is rejected");
                }
            }
            else
            {
                Console.WriteLine("The capacity hasn't been found");
            }

            // Delay
            Console.ReadKey();
        }
    }
}
