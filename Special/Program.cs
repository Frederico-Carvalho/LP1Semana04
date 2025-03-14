using System;

namespace Special
{
    public class Program
    {
        private static void Main()
        {
            Console.Write("Insert n-th number of the special sequence: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                Console.WriteLine(GetSpecial(n));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }
        private static int GetSpecial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
    }
}
