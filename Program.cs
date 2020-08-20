using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int alpha = 65;
            int u;
           // int i;
            Console.Write("Enter no : ");
            
            u = int.Parse(Console.ReadLine());  
            

             for (int i = 1; i <= u; i++)
        {
            int n = u;
 
            for (int j = 1; j <= n-i; j++)
            {
                Console.Write(" ");
            }
            for (int k = i; k >= 1; k--)
            {
                Console.Write(k);
                
                //Console.WriteLine((char)alpha);
                //alpha++;
            }
            for (int l = 2; l <= i; l++)
            {
                Console.Write(l);
                //Console.WriteLine((char)alpha);
                //alpha++;
            }
 
            Console.WriteLine();
        }

             for (int i = u - 1; i >= 1; i--)
             {
                 int n = u-1;

                 for (int j = 0; j <= n - i; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int k = i; k >= 1; k--)
                 {
                     Console.Write(k);
                 }
                 for (int l = 2; l <= i; l++)
                 {
                     Console.Write(l);
                 }

                 Console.WriteLine();
             }
        Console.ReadKey();
        }
    }
}




