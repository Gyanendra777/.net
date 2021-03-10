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
            

            string studentName;
            int studentAge;
            float marks;
            //char section = 'a';
           // bool stream = trun;
            Console.Write("your name please:");
            studentName = Console.ReadLine();
            Console.WriteLine("-----");
            Console.Write("Your age please:");
            studentAge = int.Parse(Console.ReadLine());
            Console.WriteLine("-----");
            Console.Write("Your marks please:");
            marks = float.Parse(Console.ReadLine());
            Console.WriteLine("-----");
            Console.WriteLine("type one ");
            Console.WriteLine("name--- (" + studentName + ")  age---(" + studentAge + ") mark---("+ marks);
            Console.WriteLine("type two ");
            Console.WriteLine("Name---("+ studentName);
            Console.WriteLine("age----("+ studentAge);
            Console.WriteLine("marks---(" + marks);
            Console.WriteLine("type three ");
            Console.WriteLine("name-- {0}  //age-- {1} //mark-- {2}" , studentName, studentAge, marks);
            Console.Read();
        }
    }
}
