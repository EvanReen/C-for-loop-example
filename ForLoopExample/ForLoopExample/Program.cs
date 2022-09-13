using System;

namespace ForLoopExample
{

    class Program
    {
        static void Main(String[] args)
        {
            int myVal = 15;

            int[] nums = new int[] { 1, 2, 3, 4, 5, 8, 7, 6 };

            Console.WriteLine();
            Console.WriteLine("----- Printing myVal -----");

            for (int i=0; i < myVal; i++)
            {
                Console.WriteLine("i is currently {0}", i);
            }

            Console.WriteLine();
            Console.WriteLine("----- Printing array of nums -----");

            foreach (int i in nums)
            {
                Console.WriteLine("i is currently {0}", i);
            }
        }
    }

}

            
