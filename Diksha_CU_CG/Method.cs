using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleAppCU
{
    internal class Method
    {
        void test1()
        {
            Console.WriteLine("Hello");
        }
        void test2(int x)
        {
            Console.WriteLine("this is second method: "+ x); 
        }
        string test3()
        {
            return "This is 3 method";
        }
        string test4(string name)
        {
            return "4th" + name;
        }
        void math1(int x,int y,ref int m,ref int n)
        {
            m = x + y;
            n = x * y;

        }
        void math2(int x, int y, out int m ,out int n)
        {
            m = x + y;
            n = x - y;
        }
        public static void Main(string[] args)
        {
            Method obj=new Method();
            obj.test1();
            obj.test2(100);
            Console.WriteLine(obj.test3());
            Console.WriteLine(obj.test4("tej"));
            int a = 0;int b = 0;
            obj.math1(190, 80, ref a, ref b);
            Console.WriteLine(a + " " + b);
            int q, r;
            obj.math2(120, 30, out q, out r);
            Console.WriteLine(q + " ", +r);

        }
    }
}
