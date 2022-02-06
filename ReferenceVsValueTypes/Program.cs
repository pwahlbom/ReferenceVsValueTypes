using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReferenceVsValueTypes
{
    class MyClass
    {
        public int MyProperty { get; set; }


        public int MyMethod(int1 intParameter)
        {
            return varReturn;
        }
    }

    class Prodcut
    {

        public static void Increment(ref int intParameter)
        {
            intParameter = intParameter + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var intCounter = 0;
            Prodcut.Increment(ref intCounter);
            Debug.Assert(intCounter == 1);


        }
    }
}
