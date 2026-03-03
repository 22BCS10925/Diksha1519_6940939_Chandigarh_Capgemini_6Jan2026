using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal interface inter1
    {
        void test1()
        {

        }
    }
    interface I2
    {
        void test2()
        {

        }
    }
    internal class class1 : inter1, I2
    {
        void inter1.test1()
        {
            Console.WriteLine("This is interface 1 method");
        }
        void I2.test2()
        {
            Console.WriteLine("This is interface 2 method");
        }
    }
}
