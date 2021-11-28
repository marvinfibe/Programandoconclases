using System;

namespace ejemplolambda
{
    public class Program
    {
        private delegate double Mathematical(double value);
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Started");
            Console.WriteLine();

            Mathematical doublePower = (double value) => { return Math.Pow(value, 2); };
            Mathematical halfValue = (double value) => { return value / 2; };

            Console.WriteLine(doublePower(3));
            Console.WriteLine(halfValue(3));

            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
