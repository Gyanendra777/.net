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
           first a = new first(23);
            a.first2();
            Console.ReadKey();
        }       
    }
    
    //parameterixed Constructor 
    class first
    {
        private int passingmark;
        public first(int marks)
        {
            passingmark = marks;
        }
        public void first2()
        {
            Console.WriteLine( " parameterixed constructor ====="+ passingmark);
        }
    }
}
