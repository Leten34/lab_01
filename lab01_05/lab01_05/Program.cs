using System;

namespace lab01_05
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter perimetr");
                string temp = Console.ReadLine();
                double p = Double.Parse(temp);
                double a = p / 3;
                double b = a;
                double c = a;
                p = p / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Storona\tSquar\n{0}\t{1:0.##}", a, S);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}",
            e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An DivideByZero exception was thrown: {0}", e.Message);
            }

        
        }
    }
}
