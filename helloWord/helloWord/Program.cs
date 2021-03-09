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
           first a = new first();
            a.first2();
            Console.ReadKey();
        }       
    }
    
    //Default Constructor 
    class first
    {
        public first()
        {
            Console.WriteLine("hello default chlega werd111");
        }
        public void first2()
        {
            Console.WriteLine("hello werd222");
        }
    }
}
