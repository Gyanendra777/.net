using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWord
{
    class Program
    {
        private static void Main(string[] args)
        {
            

          
            int age;
           
            
            Console.Write("plese inter your age :");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.Write("you can vot");
            }
            else
            {
                Console.Write("you connot vot");
            }
            Console.WriteLine();
            Console.Write("press any key to exit");
            Console.ReadKey();
       
        }
    }
}
