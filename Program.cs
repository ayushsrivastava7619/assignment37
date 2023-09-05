using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment37
{
    class BaseClass
    {
        private int xy;


        public BaseClass(int initialValue)
        {
            xy = initialValue;
        }


        public void sprivtepro(int newValue)
        {
            xy = newValue;
        }


        public int privtepro()
        {
            return xy;
        }
    }

    internal class Program
    {
        static void Main()
        {

            BaseClass myObject = new BaseClass(42);


            Console.WriteLine("Initial private property value: " + myObject.privtepro());

            myObject.sprivtepro(100);


            Console.WriteLine("Updated private property value: " + myObject.privtepro());
            Console.Read();
        }
    }
}
