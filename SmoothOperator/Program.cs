using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Insert a non negative integer: ");
            string input = Console.ReadLine();

            // Conversion
            byte n = byte.Parse(input);

            //increase and decrease
            Console.WriteLine(--n);
            Console.WriteLine(++n);

            //Division, shift, xor, >10
            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^5);
            Console.WriteLine(n>10);

           
            
    }
}
