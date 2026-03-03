namespace Interface
{
    internal class Program
    {
        static void Main(String[] args)
        {
            class1 obj = new class1();
            inter1 obj1 = (inter1)obj;
            I2 obj2 = (I2)obj1;
            obj1.test1();
            obj2.test2();


        }
    }
}

