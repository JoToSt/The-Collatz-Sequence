using System;
using System.Collections.Generic;


namespace CollatzProblem
{
   
    class Program
    {
        public static int CollatzProblem(   int wart_wielom  )
        {
            if (wart_wielom == 1) return 0;
            else
               if ((wart_wielom % 2) == 0)
                  return CollatzProblem((wart_wielom) / 2) +1;
               else
                  return CollatzProblem( 3 * (wart_wielom) + 1) + 1;  
        }
        static void Main(string[] args)
        {
           Console.WriteLine(" Please enter the number s: ");
           int s = int.Parse(Console.ReadLine());
           int n = CollatzProblem(  s );
           Console.WriteLine($"The number of steps:  {n}\n\n");
           

            Console.ReadKey();
        }
    }
}
