using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbers
{
    class Complex
    {
        public double Re { get; private set; }
        public double Im { get; private set; }

        private static int count=0;
        
        public Complex() { Re = 0;Im = 0; count++; }
        public Complex(double re,double im)
        {
            Re = re;
            Im = im;
            count++;
        }
        public void Print()
        {
            if(Im<0)
            {
                Console.WriteLine($"{Re}{Im}i");
            }
            Console.WriteLine($"{Re}+{Im}i");
        }
        static public Complex operator+(Complex ob1,Complex ob2)
        {
            Complex complex = new Complex();
            complex.Re = ob1.Re + ob2.Re;
            complex.Im = ob1.Im + ob2.Im;
            return complex;
        }
        static public Complex operator -(Complex ob1, Complex ob2)
        {
            Complex complex = new Complex();
            complex.Re = ob1.Re - ob2.Re;
            complex.Im = ob1.Im - ob2.Im;
            return complex;
        }
        static public Complex operator *(Complex ob1, Complex ob2)
        {
            Complex complex = new Complex();
            complex.Re = ob1.Re * ob2.Re-(ob1.Im * ob2.Im);
            complex.Im = ob1.Im*ob2.Re+ob1.Re*ob2.Im;
            return complex;
        }
        static public bool operator==(Complex ob1,Complex ob2)
        {
            return (ob1.Im == ob2.Im&&ob1.Re==ob2.Re);
        }
        static public bool operator !=(Complex ob1, Complex ob2)
        {
            return (ob1.Im != ob2.Im && ob1.Re != ob2.Re);
        }
        public override string ToString()
        {
            return Im < 0 ? $"{Re}{Im}i" : $"{Re}+{Im}i";

        }
    }
}
