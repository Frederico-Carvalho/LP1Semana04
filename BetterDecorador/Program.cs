using System;

namespace BetterDecorador

{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(Decor());
                return;
            }

            string text = args[0];
            char decorator;
            int repeat;

            if (!char.TryParse(args[1], out decorator))
            {
                return;
            }

            if (!int.TryParse(args[2], out repeat) || repeat < 0)
            {
                return;
            }

            Console.WriteLine(Decor(text, decorator, repeat));
        }

        private static string Decor(string s, char dec, int count)
        {
            string decoration = new string(dec, count);
            return $"{decoration} {s} {decoration}";
        }

        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
