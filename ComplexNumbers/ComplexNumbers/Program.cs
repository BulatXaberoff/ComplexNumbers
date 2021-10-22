using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(1, 2);
            complex1.Print();
            Complex complex2 = new Complex(2, 4);
            Complex res = new Complex();
            res = complex1 + complex2;
            res.ToString();
            Console.WriteLine(res);
        }
    }
}
