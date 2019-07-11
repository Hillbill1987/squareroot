using System;

namespace squarerootAlgo
{
    class Program
    {
        static void Main(string[] args)
        { 
            numbers num = new numbers();
            num.SquareRoot(5625);
            num.ContinuesSquareRoot(625);
            Console.ReadKey();
        }
    }
}
