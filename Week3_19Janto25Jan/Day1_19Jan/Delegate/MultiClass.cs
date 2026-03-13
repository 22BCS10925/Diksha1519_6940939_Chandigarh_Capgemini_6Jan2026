using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public delegate void Math(int x, int y);
    internal class MultiClass
    {
        public void add(int x,int y)
        {
            Console.WriteLine("Add: " +(x + y));
        }
        public void sub(int x,int y)
        {
            Console.WriteLine(x - y);
        }
        public void mult(int x,int y)
        {
            Console.WriteLine(x * y);
        }
        public void div(int x,int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
